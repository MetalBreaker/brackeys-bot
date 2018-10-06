using System;
using System.Collections.Generic;

namespace BrackeysBot
{
    /// <summary>
    /// Provides a table to store warnings.
    /// </summary>
    public class WarningTable : LookupTable<string, List < (long, string, string) > >
    {
        public override string FileName => "warns";
        public override bool RequiresTemplateFile => false;

        public Dictionary<string, List< (long, string, string) > > Warns => Table;
    }
}
