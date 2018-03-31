using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class Transfer
            {
                #region Members

                public Reprogramming Type { get; set; }
                public int ID { get; set; }
                public PRC Receiver { get; set; }
                public PRC Sender { get; set; }
                public decimal Amount { get; set; }
                public int FromId { get; set; }
                public string FromBFY { get; set; }
                public string FromBOC { get; set; }
                public string FromCode { get; set; }
                public string FromRC { get; set; }
                public string FromFund { get; set; }
                public string FromOrg { get; set; }
                public string FromRPIO { get; set; }
                public decimal FromAmount { get; set; }
                public string Purpose { get; set; }
                public int ToId { get; set; }
                public string ToBFY { get; set; }
                public string ToBOC { get; set; }
                public string ToCode { get; set; }
                public string ToRC { get; set; }
                public string ToFund { get; set; }
                public string ToOrg { get; set; }
                public decimal ToAmount { get; set; }
                public string ToRPIO { get; set; }
                public string ControlNumber { get; set; }

                #endregion Members

                #region Constructors

                public Transfer( )
                {
                }

                // used for both internal and external transfers using existing prc objects
                public Transfer(PRC sender, PRC receiver, decimal amount)
                {
                    ControlNumber = GetTransferControlNumber( );
                    Amount = amount;
                    Sender = sender;
                    FromId = sender.ID;
                    FromBFY = sender.BFY;
                    FromBOC = sender.BOC.Code;
                    FromCode = sender.Account.Code;
                    FromFund = sender.Fund.Code;
                    FromOrg = sender.Org;
                    FromRPIO = sender.RPIO;
                    FromAmount = sender.Amount;
                    Receiver = receiver;
                    ToId = receiver.ID;
                    ToBFY = receiver.BFY;
                    ToBOC = receiver.BOC.Code;
                    ToCode = receiver.Account.Code;
                    ToFund = receiver.Fund.Code;
                    ToOrg = receiver.Org;
                    ToRPIO = receiver.RPIO;
                    ToAmount = receiver.Amount;
                }

                // used for both internal and external transfers
                // intiatiates transfer object creating prc objects Fr datarows
                // prcs must exist in prc table with id properties prior to instatiating
                public Transfer(DataRow sender, DataRow receiver, decimal amount)
                {
                    ControlNumber = GetTransferControlNumber( );
                    Amount = amount;
                    FromId = int.Parse(sender["Id"].ToString( ));
                    FromBFY = sender["BFY"].ToString( );
                    FromBOC = sender["BOC"].ToString( );
                    FromCode = sender["Code"].ToString( );
                    FromFund = sender["Fund"].ToString( );
                    FromOrg = sender["Org"].ToString( );
                    FromRPIO = sender["RPIO"].ToString( );
                    FromAmount = decimal.Parse(sender["Amount"].ToString( ));
                    ToId = int.Parse(receiver["Id"].ToString( ));
                    ToBFY = receiver["BFY"].ToString( );
                    ToBOC = receiver["BOC"].ToString( );
                    ToCode = receiver["Code"].ToString( );
                    ToFund = receiver["Fund"].ToString( );
                    ToOrg = receiver["Org"].ToString( );
                    ToRPIO = receiver["RPIO"].ToString( );
                    ToAmount = decimal.Parse(receiver["Amount"].ToString( ));
                }

                #endregion Constructors

                #region Methods

                internal Dictionary<string, object> GetInternalData( )
                {
                    try
                    {
                        Dictionary<string, object> param = new Dictionary<string, object>( );
                        param.Add("Id", ID);
                        param.Add("ControlNumber", ControlNumber);
                        param.Add("FrRpio", FromRPIO);
                        param.Add("ToRpio", ToRPIO);
                        param.Add("FrOrg", FromOrg);
                        param.Add("ToOrg", ToOrg);
                        param.Add("FrFund", FromFund);
                        param.Add("ToFund", ToFund);
                        param.Add("FrBFY", FromBFY);
                        param.Add("ToBFY", ToBFY);
                        param.Add("FrCode", FromCode);
                        param.Add("ToCode", ToCode);
                        param.Add("FrBOC", FromBOC);
                        param.Add("ToBOC", ToBOC);
                        param.Add("Amount", Amount);
                        param.Add("FrDivision", FromRC);
                        param.Add("ToDivision", ToRC);
                        return param;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString( ) + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return null;
                    }
                }

                internal string GetTransferControlNumber( )
                {
                    try
                    {
                        DateTime dt = DateTime.Now;
                        StringBuilder cn = new StringBuilder( );
                        cn.Append("06");
                        cn.Append(dt.Year.ToString( ));
                        cn.Append("-");
                        cn.Append(FromBFY ?? ToBFY);
                        cn.Append(FromFund ?? ToFund);
                        cn.Append("-");
                        cn.Append(FromRC ?? ToRC);
                        cn.Append("-");
                        cn.Append(FromCode ?? ToCode);
                        cn.Append("-");
                        cn.Append(dt.Month.ToString( ));
                        cn.Append(dt.Day.ToString( ));
                        cn.Append("-");
                        cn.Append(dt.Hour.ToString( ));
                        cn.Append(dt.Minute.ToString( ));
                        return cn.ToString( );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR!\n\n" + $"Target Method: {ex.TargetSite}\n\n" + $"Stack: {ex.StackTrace}\n\n");
                        return null;
                    }
                }

                internal void WriteTransfer( )
                {
                    try
                    {
                        string path = $@"c:\EPA\TransferLog\transfers.txt";
                        File.AppendAllText(path, ToString( ));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR!\n\n" + $"Target Method: {ex.TargetSite}\n\n" + $"Stack: {ex.StackTrace}\n\n");
                    }
                }

                #endregion Methods
            }
        }
    }
}