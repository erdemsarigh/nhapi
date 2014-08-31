/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "DBTableRepository.java".  Description: 
/// "Implements TableRepository by looking up values from the default HL7
/// normative database" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  �GPL�), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>

namespace NHapi.Base
{
    using System;

    using NHapi.Base.Log;

    /// <summary>
    /// Implements TableRepository by looking up values from the default HL7 normative database.
    /// Values are cached after they are looked up once.  
    /// </summary>

    public class DBTableRepository : TableRepository
    {
        #region Static Fields

        /// <summary>   The log. </summary>
        private static readonly IHapiLog log;

        #endregion

        #region Fields

        /// <summary>   max # of tables or values that can be cached at a time. </summary>
        private int bufferSize = 3000;

        /// <summary>   List of tables. </summary>
        private int[] tableList;

        /// <summary>   The tables. </summary>
        private System.Collections.Hashtable tables;

        #endregion

        #region Constructors and Destructors

        /// <summary>   Initializes static members of the DBTableRepository class. </summary>
        static DBTableRepository()
        {
            log = HapiLogFactory.GetHapiLog(typeof(DBTableRepository));
        }

        /// <summary>   Table repository. </summary>
        protected internal DBTableRepository()
        {
            this.tableList = null;
            this.tables = new System.Collections.Hashtable();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Returns a list of HL7 lookup tables that are defined in the normative database.
        /// </summary>
        ///
        /// <value> The tables. </value>

        public override int[] Tables
        {
            get
            {
                if (this.tableList == null)
                {
                    try
                    {
                        System.Data.OleDb.OleDbConnection conn = NormativeDatabase.Instance.Connection;
                        System.Data.OleDb.OleDbCommand stmt =
                            SupportClass.TransactionManager.manager.CreateStatement(conn);
                        System.Data.OleDb.OleDbCommand temp_OleDbCommand;
                        temp_OleDbCommand = stmt;
                        temp_OleDbCommand.CommandText = "select distinct table_id from TableValues";
                        System.Data.OleDb.OleDbDataReader rs = temp_OleDbCommand.ExecuteReader();
                        int[] roomyList = new int[this.bufferSize];
                        int c = 0;
                        while (rs.Read())
                        {
                            roomyList[c++] = rs.GetInt32(1 - 1);
                        }
                        stmt.Dispose();
                        NormativeDatabase.Instance.returnConnection(conn);

                        this.tableList = new int[c];
                        Array.Copy(roomyList, 0, this.tableList, 0, c);
                    }
                    catch (System.Data.OleDb.OleDbException sqle)
                    {
                        throw new LookupException("Can't get table list from database: " + sqle.Message);
                    }
                }
                return this.tableList;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>   Returns true if the given value exists in the given table. </summary>
        ///
        /// <param name="table">            The table. </param>
        /// <param name="value_Renamed">    The value renamed. </param>
        ///
        /// <returns>   true if it succeeds, false if it fails. </returns>

        public override bool checkValue(int table, System.String value_Renamed)
        {
            bool exists = false;

            System.String[] values = this.getValues(table);

            int c = 0;
            while (c < values.Length && !exists)
            {
                if (value_Renamed.Equals(values[c++]))
                {
                    exists = true;
                }
            }

            return exists;
        }

        /// <summary>
        /// Returns the description matching the table and value given.  As currently implemented this
        /// method performs a database call each time - caching should probably be added, although this
        /// method will probably not be used very often.
        /// </summary>
        ///
        /// <exception cref="UnknownValueException">    Thrown when an Unknown Value error condition
        ///                                             occurs. </exception>
        /// <exception cref="LookupException">          Thrown when a Lookup error condition occurs. </exception>
        ///
        /// <param name="table">            The table. </param>
        /// <param name="value_Renamed">    The value renamed. </param>
        ///
        /// <returns>   The description. </returns>

        public override System.String getDescription(int table, System.String value_Renamed)
        {
            System.String description = null;

            System.Text.StringBuilder sql =
                new System.Text.StringBuilder("select Description from TableValues where table_id = ");
            sql.Append(table);
            sql.Append(" and table_value = '");
            sql.Append(value_Renamed);
            sql.Append("'");

            try
            {
                System.Data.OleDb.OleDbConnection conn = NormativeDatabase.Instance.Connection;
                System.Data.OleDb.OleDbCommand stmt = SupportClass.TransactionManager.manager.CreateStatement(conn);
                System.Data.OleDb.OleDbCommand temp_OleDbCommand;
                temp_OleDbCommand = stmt;
                temp_OleDbCommand.CommandText = sql.ToString();
                System.Data.OleDb.OleDbDataReader rs = temp_OleDbCommand.ExecuteReader();
                if (rs.Read())
                {
                    description = System.Convert.ToString(rs[1 - 1]);
                }
                else
                {
                    throw new UnknownValueException(
                        "The value " + value_Renamed + " could not be found in the table " + table + " - SQL: " + sql);
                }
                stmt.Dispose();
                NormativeDatabase.Instance.returnConnection(conn);
            }
            catch (System.Data.OleDb.OleDbException e)
            {
                throw new LookupException("Can't find value " + value_Renamed + " in table " + table, e);
            }

            return description;
        }

        /// <summary>
        /// Returns a list of the values for the given table in the normative database.
        /// </summary>
        ///
        /// <exception cref="LookupException">          Thrown when a Lookup error condition occurs. </exception>
        /// <exception cref="UndefinedTableException">  Thrown when an Undefined Table error condition
        ///                                             occurs. </exception>
        ///
        /// <param name="table">    The table. </param>
        ///
        /// <returns>   An array of string. </returns>

        public override System.String[] getValues(int table)
        {
            System.Int32 key = table;
            System.String[] values = null;

            //see if the value list exists in the cache
            System.Object o = this.tables[key];

            if (o != null)
            {
                values = (System.String[])o;
            }
            else
            {
                //not cached yet ...
                int c;
                System.String[] roomyValues = new System.String[this.bufferSize];

                try
                {
                    System.Data.OleDb.OleDbConnection conn = NormativeDatabase.Instance.Connection;
                    System.Data.OleDb.OleDbCommand stmt = SupportClass.TransactionManager.manager.CreateStatement(conn);
                    System.Text.StringBuilder sql =
                        new System.Text.StringBuilder("select table_value from TableValues where table_id = ");
                    sql.Append(table);
                    System.Data.OleDb.OleDbCommand temp_OleDbCommand;
                    temp_OleDbCommand = stmt;
                    temp_OleDbCommand.CommandText = sql.ToString();
                    System.Data.OleDb.OleDbDataReader rs = temp_OleDbCommand.ExecuteReader();

                    c = 0;
                    while (rs.Read())
                    {
                        roomyValues[c++] = System.Convert.ToString(rs[1 - 1]);
                    }

                    stmt.Dispose();
                    NormativeDatabase.Instance.returnConnection(conn);
                }
                catch (System.Data.OleDb.OleDbException sqle)
                {
                    throw new LookupException("Couldn't look up values for table " + table + ": " + sqle.Message);
                }

                if (c == 0)
                {
                    throw new UndefinedTableException("No values found for table " + table);
                }

                values = new System.String[c];
                Array.Copy(roomyValues, 0, values, 0, c);

                this.tables[key] = values;
            }

            return values;
        }

        #endregion
    }
}