using System;
using System.Collections.Generic;

namespace Exercise3Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UserError> UE = new List<UserError>();
            UserError NError, TError,NIError,NZNError,NVSError;
            NError = new NumericInputError();
            TError = new TextInputError();
            NIError = new NullInputError();
            NZNError = new NegativeZeroNumericError();
            NVSError= new NumericValueSeperatorError();
            UE.Add(NError);
            UE.Add(TError);
            UE.Add(NIError);
            UE.Add(NZNError);
            UE.Add(NVSError);
            foreach (var e in UE)
                Console.WriteLine(e.UEMessage());


        }
    }
}
