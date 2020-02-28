using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquirrelyLogging {
    internal class StringBuilder {

        //Todo: Do this dummy
        public static string BuildString(Exception ex) =>
            $"Source::  {ex.Source}/n" +
            $"Message::  {ex.Message}/n" +
            $"Stack Trace::  {ex.StackTrace}/n" +
            $"Help Link::  {ex.HelpLink}";
    }
}
