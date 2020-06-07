using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EurekaLogosMixerProbability", columnHash: 0xdcfd9eba )]
    public class EurekaLogosMixerProbability : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public byte ProbabilityPct;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            ProbabilityPct = parser.ReadOffset< byte >( 0x0 );


        }
    }
}