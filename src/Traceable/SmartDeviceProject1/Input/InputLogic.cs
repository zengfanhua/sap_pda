using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using SmartDeviceProject1.Common;
using SmartDeviceProject1.Webservice1;

namespace SmartDeviceProject1.Input
{
    public class InputLogic
    {
        public static bool ConfirmOrder(string productionOrder)
        {
            Zppi501 item = new Zppi501();
            item.Aufnr = "";
            item.Return = new Zsdmsg01[10];

            Zppi501Response response = GlobalState.GetWebService().Zppi501(item);
            try
            {
                if (response.Return == null || response.Return.Length == 0)
                    throw new BusinessException("调用确认生产订单接口失败。");

                if (response.Return[0].Message == "N")
                    throw new BusinessException("该生产订单不可用。");

                if (response.Return[0].Message == "Y" && response.Werks != GlobalState.Werks)
                    throw new BusinessException("该PDA默认工厂和生产订单不一致。");

                return true;
            }
            catch (Exception exception)
            {
                throw new BusinessException("调用确认生产订单接口失败。");
            }

            return false;
        }

        public static bool ConformLine(string productionLine)
        {
            return true;
        }

        public static bool InputMaterial(MaterialModel model)
        {
            Zppi511 item = new Zppi511();
            item.Aufnr = model.Aufnr;
            item.Werks = model.Werks;
            item.Zplin = model.Zplin;
            item.Charg = model.Charg;
            item.Zpnum = model.Zpnum;
            item.Matnr = model.Matnr;
            item.Meins = model.Meins;
            item.Menge = model.Menge;
            item.Zmengd = model.Zmengd;
            item.Zgrop = model.Zgrop;

            Zppi511Response response = GlobalState.GetWebService().Zppi511(item);
            try
            {
                if (response.Return[0].Message == "Y")
                    return true;
            }
            catch (Exception exception)
            {
                throw new BusinessException("投料失败。", exception);
            }

            return false;
        }

        public static bool ReturnMaterial(MaterialModel model)
        {
            Zppi512 item = new Zppi512();
            item.Aufnr = model.Aufnr;
            item.Werks = model.Werks;
            item.Zplin = model.Zplin;
            item.Charg = model.Charg;
            item.Zpnum = model.Zpnum;
            item.Matnr = model.Matnr;
            item.Meins = model.Meins;
            item.Menge = model.Menge;
            item.Zmengd = model.Zmengd;
            item.Zgrop = model.Zgrop;

            Zppi512Response response = GlobalState.GetWebService().Zppi512(item);
            try
            {
                if (response.Return[0].Message == "Y")
                    return true;
            }
            catch (Exception exception)
            {
                throw new BusinessException("退料失败。", exception);
            }

            return false;
        }
    }
}
