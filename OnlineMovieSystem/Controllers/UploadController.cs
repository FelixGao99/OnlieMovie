using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineMovieSystem.Controllers
{
    // 附件上传控制器
    public class UploadController : Controller
    {
        // 上传电影海报
        [HttpPost]
        public JObject UploadMoviePoster(HttpPostedFileBase img)
        {
            JObject result = new JObject();

            if (img == null)
            {
                result["flag"] = false;
                result["msg"] = "请先选择要上传的图片！";
                return result;
            }

            var fileName = img.FileName;
            var filePath = Server.MapPath("~/Upload/Images/");
            var fileViewPath = Url.Content(string.Format("~/Upload/Images/{0}", fileName));

            try
            {
                img.SaveAs(Path.Combine(filePath, fileName));
                result["flag"] = true;
                result["msg"] = "上传成功！";
                result["path"] = fileViewPath;
            }
            catch
            {
                result["flag"] = false;
                result["msg"] = "上传失败！";
            }

            return result;
        }

    }
}