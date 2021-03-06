using System.IO;

using Aspose.Cells;
using System;

namespace CSharp.Data.Processing
{
    public class TracingPrecedents
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            
            Workbook workbook = new Workbook(dataDir + "Book1.xlsx");
            Cells cells = workbook.Worksheets[0].Cells;
            Cell cell = cells["B4"];

            ReferredAreaCollection ret = cell.GetPrecedents();
            ReferredArea area = ret[0];
            Console.WriteLine(area.SheetName);
            Console.WriteLine(CellsHelper.CellIndexToName(area.StartRow, area.StartColumn));
            Console.WriteLine(CellsHelper.CellIndexToName(area.EndRow, area.EndColumn));
            // ExEnd:1
            Console.ReadKey();
        }
    }
}
