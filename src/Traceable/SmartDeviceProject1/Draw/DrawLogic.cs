using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using SmartDeviceProject1.Common;
using SmartDeviceProject1.Webservice1;

namespace SmartDeviceProject1.Draw
{
    public class DrawLogic
    {
        public static bool ConfirmReservedNumber(string number, out string receivingLocation, out string issueLocation)
        {
            issueLocation = string.Empty;
            receivingLocation = string.Empty; 

            Zppi506 item = new Zppi506();
            item.Rsnum = number;
            item.Return = new Zsdmsg01[10];

            Zppi506Response response = GlobalState.GetWebService().Zppi506(item);
            try
            {
                if (response.Return[0].Message == "Y")
                {
                    issueLocation = response.Fhkw;
                    receivingLocation = response.Jskw;

                    return true;
                }
            }
            catch (Exception exception)
            {
                throw new BusinessException("调用确认预留号接口失败。");
            }

            return false;
        }

        public static bool ConfirmDrawMaterial(MaterialModel model)
        {
            Zppi515 item = new Zppi515();
            item.Werks = model.Werks;
            item.Charg = model.Charg;
            item.Zpnum = model.Zpnum;
            item.Matnr = model.Matnr;
            item.Meins = model.Meins;
            item.Menge = model.Menge;
            item.Rsnum = model.Rsnum;
            item.Zgetl = model.Zgetl;
            item.Zissl = model.Zissl;
            item.Zusrd = model.Zusrd;


            Zppi515Response response = GlobalState.GetWebService().Zppi515(item);
            try
            {
                if (response.Return[0].Message == "Y")
                    return true;
            }
            catch (Exception exception)
            {
                throw new BusinessException("确认领料失败。", exception);
            }

            return false;
        }

        public static bool UploadDrawMaterial(MaterialModel model)
        {
            Zppi517 item = new Zppi517();
            item.Werks = model.Werks;
            item.Charg = model.Charg;
            item.Zpnum = model.Zpnum;
            item.Matnr = model.Matnr;
            item.Meins = model.Meins;
            item.Menge = model.Menge;
            item.Rsnum = model.Rsnum;
            item.Zgetl = model.Zgetl;
            item.Zissl = model.Zissl;
            item.Zusrd = model.Zusrd;


            Zppi517Response response = GlobalState.GetWebService().Zppi517(item);
            try
            {
                if (response.Return[0].Message == "Y")
                    return true;
            }
            catch (Exception exception)
            {
                throw new BusinessException("提交领料失败。", exception);
            }

            return false;
        }

        public static bool DeleteDrawMaterial(MaterialModel model)
        {
            Zppi516 item = new Zppi516();
            item.Werks = model.Werks;
            item.Charg = model.Charg;
            item.Zpnum = model.Zpnum;
            item.Matnr = model.Matnr;
            item.Meins = model.Meins;
            item.Menge = model.Menge;
            item.Rsnum = model.Rsnum;
            item.Zgetl = model.Zgetl;
            item.Zissl = model.Zissl;
            item.Zusrd = model.Zusrd;


            Zppi516Response response = GlobalState.GetWebService().Zppi516(item);
            try
            {
                if (response.Return[0].Message == "Y")
                    return true;
            }
            catch (Exception exception)
            {
                throw new BusinessException("取消领料失败。", exception);
            }

            return false;
        }

        
    }
}
