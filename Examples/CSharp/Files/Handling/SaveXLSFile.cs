using System.IO;

using Aspose.Cells;
using System;

namespace CSharp.Files.Handling
{
    public class SaveXLSFile
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            // Load your source workbook
            Workbook workbook = new Workbook();
            // Save in Excel2007 xlsx format
            workbook.Save(dataDir + "output.xls");
            // ExEnd:1
        }
    }
}
