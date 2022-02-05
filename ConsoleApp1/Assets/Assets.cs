using ConsoleApp1.bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assets
{
    public class assets : BaseWithName
    {
        public int OriginalValue { get; set; }
        public enum Currency {}
        public enum Method { }//اي سر انه مش راضي ياخد get?
        public double NotDepreciableValue { get; set; }
        public double BookValue { get; set; }

        public int Duration { get; set; }
        public DateTime StartDepreciating { get; set; }
        public enum FixedAssetAccount {  }
        public enum DrainingAccount { }
        public enum ExpenseAccount {  }
        public enum Journal {  }

        
    }
}
