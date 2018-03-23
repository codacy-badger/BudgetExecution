#region Using Directives

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MetroForm = Syncfusion.Windows.Forms.MetroForm;

#endregion

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public partial class MainNavigation : MetroForm
            {
                public new RegionalAuthority Region { get; }
                public DivisionAuthority Division { get; }
                public Dictionary<string, decimal>[] Info { get; set; }
                public string[] Title { get; set; }
                public GetChart Chart { get; set; }
                public int Counter { get; set; }
                public System.Windows.Forms.Timer Timer { get; set; }

                public MainNavigation( )
                {
                    InitializeComponent( );
                    Region = new RegionalAuthority( );
                    Division = new DivisionAuthority( );
                    Timer = new Timer( );
                    Chart = new GetChart(GetMainChart);
                    Info = new Dictionary<string, decimal>[] { Region.FundData, Region.BocData, Region.FteInfo, Region.NpmData, Region.GoalInfo,
                Division.DivisionData, Division.BocData, Division.NpmData, Division.GoalData };
                    Title = GetChartTitles(Info);
                    MainChart = Chart(MainChart, Title[1], Division.BocData);
                }

                private string[] GetChartTitles(Dictionary<string, decimal>[] Info)
                {
                    var t = new string[Info.Length];
                    t[0] = "P7 Funds by Appropriation";
                    t[1] = "P7 Funds by Object Class";
                    t[2] = "P7 FTE by Appropriation";
                    t[3] = "P7 Funds by HQ NPM";
                    t[4] = "P7 Funds by Agency Goal";
                    t[5] = "P7 Funds by Division";
                    t[6] = "Division Funds by Object Class";
                    t[7] = "Division Funds by HQ NPM";
                    t[8] = "Division Funds by Agency Goal";
                    return t;
                }

                private void MainNavigation_Load(object sender, EventArgs e)
                {
                    Counter = 0;
                    Timer.Tick += ChartTimer;
                    Timer.Enabled = true;
                    Timer.Interval = 5000;
                }

                #region TileLayout

                private void GetLayouts( )
                {
                    var tilelayout = new TileLayout( );
                    var layoutgroup = new LayoutGroup( );
                    var imgstreamer = new ImageStreamer( );
                    Controls.Add(tilelayout);

                    //TileLayout
                    Controls.Add(layoutgroup);
                    tilelayout.Location = new Point(0, 0);
                    tilelayout.Name = "TileLayout";
                    tilelayout.SetParentFormFlat = true;
                    tilelayout.ShowGroupTitle = true;
                    tilelayout.ShowItemPreview = true;
                    tilelayout.Size = new Size(545, 394);

                    //LayoutGroup
                }

                #endregion

                #region Chart Timer EventHandler

                private ChartControl GetMainChart(ChartControl chart, string[] title, Dictionary<string, decimal> data)
                {
                    MainChart = new Chart(chart, title[0], data).CreateColumn( );
                    return MainChart;
                }

                private ChartControl GetMainChart(ChartControl chart, string title, Dictionary<string, decimal> data)
                {
                    MainChart = new Chart(chart, title, data).CreateColumn( );
                    return MainChart;
                }

                private void ChartTimer(object sender, EventArgs e)
                {
                    if (Counter >= Info.Length)
                    {
                        Counter = 0;
                        MainChart = Chart(MainChart, Title[Counter], Info[Counter]);
                        Counter++;
                    }
                    if (Counter < Info.Length)
                    {
                        MainChart = Chart(MainChart, Title[Counter], Info[Counter]);
                        Counter++;
                    }
                }

                #endregion

                #region HubTile Methods

                private void ConfigureDefaultTile( )
                {
                    //AppropTile.Title.Text = "Appropriations";
                    //AppropTile.Title.TextColor = Color.White;
                    //AppropTile.Footer.Text = "HubTile";
                    //AppropTile.Footer.TextColor = Color.White;
                    //AppropTile.TileType = HubTileType.DefaultTile;

                    //image transitiion configuration
                    //AppropTile.TurnLiveTileOn = true;
                    //AppropTile.SlideTransition = TransitionDirection.BottomToTop;
                    //AppropTile.ImageTransitionSpeed = 3;

                    //banner configuration
                    //AppropTile.ShowBanner = true;
                    //AppropTile.BannerColor = Color.Green;
                    //AppropTile.Banner.Text = "Budget Fiscal Year 2018";
                    //AppropTile.Banner.TextColor = Color.White;
                    //AppropTile.ShowBannerIcon = true;
                    //hubTile5.BannerIcon = ImageListAdv.Images[0];

                    //selection marker configuration
                    //AppropTile.IsSelectionMarked = true;
                    //AppropTile.SelectionMarkerColor = Color.Blue;

                    //hover expansion
                    //AppropTile.HoveredBorderColor = Color.Green;
                    //AppropTile.EnableHoverColor = true;

                    //image configuration
                    //hubTile5.ImageListAdv = ImageListAdv;
                    //hubTile5.ImageList = ImageList;

                    //button press effect
                    //AppropTile.EnableTileSlideEffect = true;
                }

                private void hubTile2_Click(object sender, EventArgs e)
                {
                }

                private void hubTile6_Click(object sender, EventArgs e)
                {
                }

                private void SummaryTile_OnClicked(object sender, EventArgs e)
                {
                    var sum = new SummarySelector( );
                    sum.ShowDialog( );
                }

                private void DataTile_OnClicked(object sender, EventArgs e)
                {
                }

                #endregion

                #region Button Methods & EventHandlers

                private void P7Btn_OnClick(object sender, EventArgs e)
                {
                    var r6 = new SummaryForm(Source.P7);
                    r6.ShowDialog( );
                }

                private void P8Btn_OnClick(object sender, EventArgs e)
                {
                    var division = new SummaryForm(Source.P8);
                    division.ShowDialog( );
                }

                private void DivisionBtn_OnClick(object sender, EventArgs e)
                {
                }

                private void TransferBtn_OnClick(object sender, EventArgs e)
                {
                    var d6select = new FunctionalityForm( );
                    d6select.Show( );
                }

                private void DataButton_Clicked(object sender, EventArgs e)
                {
                    
                }

                #endregion
            }
        }
    }
}