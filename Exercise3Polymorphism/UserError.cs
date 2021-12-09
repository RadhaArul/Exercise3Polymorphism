using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Polymorphism
{
    public abstract class UserError
    {
        public abstract string UEMessage();
    }
    public class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return " You tried to use a numeric input in a text only field. This fired an error!";
        }
    }
    public class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error! ";
        }
    }

    public class NullInputError : UserError
    {
        public override string UEMessage()
        {
            return "Field should not be Null. This fired an error!";
        }
    }
    public class NegativeZeroNumericError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use Negative or Zero input. This fired an error! ";
        }
    }
    public class NumericValueSeperatorError : UserError
    {
        public override string UEMessage()
        {
            return "Yor tried to give wrong format of input. This fired an error! ";
        }
    }
}
