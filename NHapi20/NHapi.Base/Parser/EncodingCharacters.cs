/// <summary> 
/// The contents of this file are subject to the Mozilla Public License Version 1.1
/// 
/// (the "License"); you may not use this file except in compliance with the License.
/// 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// 
/// Software distributed under the License is distributed on an "AS IS" basis,
/// 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// 
/// specific language governing rights and limitations under the License.
/// 
/// 
/// 
/// The Original Code is "EncodingCharacters.java".  Description:
/// 
/// "Represents the set of special characters used to encode traditionally
/// 
/// encoded HL7 messages"
/// 
/// 
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 
/// 2001.  All Rights Reserved.
/// 
/// 
/// 
/// Contributor(s): ______________________________________.
/// 
/// 
/// 
/// Alternatively, the contents of this file may be used under the terms of the
/// 
/// GNU General Public License (the  “GPL”), in which case the provisions of the GPL are
/// 
/// applicable instead of those above.  If you wish to allow use of your version of this
/// 
/// file only under the terms of the GPL and not to allow others to use your version
/// 
/// of this file under the MPL, indicate your decision by deleting  the provisions above
/// 
/// and replace  them with the notice and other provisions required by the GPL License.
/// 
/// If you do not delete the provisions above, a recipient may use your version of
/// 
/// this file under either the MPL or the GPL.
/// 
/// 
/// 
/// </summary>

namespace NHapi.Base.Parser
{
    /// <summary>
    /// Represents the set of special characters used to encode traditionally
    /// 
    /// encoded HL7 messages.
    /// </summary>

    public class EncodingCharacters : System.Object, System.ICloneable
    {
        #region Fields

        /// <summary>   The encode characters. </summary>
        private char[] encChars;

        /// <summary>   The field separator. </summary>
        private char fieldSep;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Creates new EncodingCharacters object with the given character
        /// 
        /// values. If the encodingCharacters argument is null, the default
        /// 
        /// values are used.
        /// </summary>
        ///
        /// <param name="fieldSeparator">       The field separator. </param>
        /// <param name="encodingCharacters">   consists of the characters that appear in
        ///                                     
        ///                                     MSH-2 (see section 2.8 of the HL7 spec).  The characters
        ///                                     are
        ///                                     
        ///                                     Component Separator, Repetition Separator, Escape
        ///                                     Character, and
        ///                                     
        ///                                     Subcomponent Separator (in that order). </param>

        public EncodingCharacters(char fieldSeparator, System.String encodingCharacters)
        {
            this.fieldSep = fieldSeparator;

            this.encChars = new char[4];

            if (encodingCharacters == null)
            {
                this.encChars[0] = '^';

                this.encChars[1] = '~';

                this.encChars[2] = '\\';

                this.encChars[3] = '&';
            }
            else
            {
                SupportClass.GetCharsFromString(encodingCharacters, 0, 4, this.encChars, 0);
            }
        }

        /// <summary>
        /// Creates new EncodingCharacters object with the given character
        /// 
        /// values. If the encodingCharacters argument is null, the default
        /// 
        /// values are used.
        /// </summary>
        ///
        /// <param name="fieldSeparator">           The field separator. </param>
        /// <param name="componentSeparator">       The component separator. </param>
        /// <param name="repetitionSeparator">      The repetition separator. </param>
        /// <param name="escapeCharacter">          The escape character. </param>
        /// <param name="subcomponentSeparator">    The subcomponent separator. </param>

        public EncodingCharacters(
            char fieldSeparator,
            char componentSeparator,
            char repetitionSeparator,
            char escapeCharacter,
            char subcomponentSeparator)
            : this(
                fieldSeparator,
                System.Convert.ToString(componentSeparator) + repetitionSeparator + escapeCharacter
                + subcomponentSeparator)
        {
        }

        /// <summary>   copies contents of "other". </summary>
        ///
        /// <param name="other">    The other. </param>

        public EncodingCharacters(EncodingCharacters other)
        {
            this.fieldSep = other.FieldSeparator;

            this.encChars = new char[4];

            this.encChars[0] = other.ComponentSeparator;

            this.encChars[1] = other.RepetitionSeparator;

            this.encChars[2] = other.EscapeCharacter;

            this.encChars[3] = other.SubcomponentSeparator;
        }

        #endregion

        #region Public Properties

        /// <summary>   Returns the component separator. </summary>
        ///
        /// <value> The component separator. </value>

        public virtual char ComponentSeparator
        {
            get
            {
                return this.encChars[0];
            }

            set
            {
                this.encChars[0] = value;
            }
        }

        /// <summary>   Returns the escape character. </summary>
        ///
        /// <value> The escape character. </value>

        public virtual char EscapeCharacter
        {
            get
            {
                return this.encChars[2];
            }

            set
            {
                this.encChars[2] = value;
            }
        }

        /// <summary>   Returns the field separator. </summary>
        ///
        /// <value> The field separator. </value>

        public virtual char FieldSeparator
        {
            get
            {
                return this.fieldSep;
            }

            set
            {
                this.fieldSep = value;
            }
        }

        /// <summary>   Returns the repetition separator. </summary>
        ///
        /// <value> The repetition separator. </value>

        public virtual char RepetitionSeparator
        {
            get
            {
                return this.encChars[1];
            }

            set
            {
                this.encChars[1] = value;
            }
        }

        /// <summary>   Returns the subcomponent separator. </summary>
        ///
        /// <value> The subcomponent separator. </value>

        public virtual char SubcomponentSeparator
        {
            get
            {
                return this.encChars[3];
            }

            set
            {
                this.encChars[3] = value;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>   Creates a new object that is a copy of the current instance. </summary>
        ///
        /// <returns>   A new object that is a copy of this instance. </returns>

        public virtual System.Object Clone()
        {
            return new EncodingCharacters(this);
        }

        /// <summary>   Tests if this System.Object is considered equal to another. </summary>
        ///
        /// <param name="o">    The object to compare to this object. </param>
        ///
        /// <returns>   true if the objects are considered equal, false if they are not. </returns>
        ///
        /// <seealso cref="java.lang.Object.equals"/>
        /// ### <param name="obj">  The <see cref="T:System.Object" /> to compare with the current
        ///                         <see cref="T:System.Object" />. </param>

        public override bool Equals(System.Object o)
        {
            if (o is EncodingCharacters)
            {
                EncodingCharacters other = (EncodingCharacters)o;
                if (this.FieldSeparator == other.FieldSeparator && this.ComponentSeparator == other.ComponentSeparator
                    && this.EscapeCharacter == other.EscapeCharacter
                    && this.RepetitionSeparator == other.RepetitionSeparator
                    && this.SubcomponentSeparator == other.SubcomponentSeparator)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        /// <summary>   Returns a hash code for this object. </summary>
        ///
        /// <returns>   A hash code for this object. </returns>
        ///
        /// <seealso cref="java.lang.Object.hashCode"/>

        public override int GetHashCode()
        {
            return 7 * this.ComponentSeparator * this.EscapeCharacter * this.FieldSeparator * this.RepetitionSeparator
                   * this.SubcomponentSeparator;
        }

        /// <summary>
        /// Returns the encoding characters (not including field separator)
        /// 
        /// as a string.
        /// </summary>
        ///
        /// <returns>   A System.String that represents this object. </returns>

        public override System.String ToString()
        {
            System.Text.StringBuilder ret = new System.Text.StringBuilder();

            for (int i = 0; i < this.encChars.Length; i++)
            {
                ret.Append(this.encChars[i]);
            }

            return ret.ToString();
        }

        #endregion

        /// <summary> 
        /// Test harness ...
        /// 
        /// </summary>

        /*
		
        public static void main(String args[]) {
		
        String testChars = "^~\\&";
		
        String testChars2 = "$%*+";
		
		
		
        EncodingCharacters ec = new EncodingCharacters('|', testChars);
		
        System.out.println("test 1: " + ec.getFieldSeparator() + ec.toString());
		
        ec = new EncodingCharacters('|', testChars2);
		
        System.out.println("test 2: " + ec.getFieldSeparator() + ec.getComponentSeparator() + ec.getRepetitionSeparator() + ec.getEscapeCharacter() + ec.getSubcomponentSeparator());
		
        ec = new EncodingCharacters('[', null);
		
        System.out.println("test 3: " + ec.getFieldSeparator() + ec.toString());
		
        }*/
    }
}