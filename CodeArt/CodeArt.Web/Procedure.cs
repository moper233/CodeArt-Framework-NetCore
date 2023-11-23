using CodeArt.DTO;
using Microsoft.AspNetCore.Mvc;

namespace CodeArt.Web
{
    public class RequestBody
    {
        public string Arg { get; set; }
    }

    [ApiController]
    [Route("Api/[controller]")]
    public abstract class Procedure : ControllerBase
    {

        //public virtual DTObject Invoke(DTObject arg)
        //{
        //    return InvokeDynamic(arg);
        //}

        protected virtual DTObject InvokeDynamic(dynamic arg)
        {
            return DTObject.Empty;
        }


        /// <summary>
        /// post请求
        /// </summary>
        /// <param name="model">使用boby读取参数方式</param>
        /// <returns></returns>
        [HttpPost]
        public string Post([FromBody] RequestBody? model = null)
        {
            var data = DTObject.Create(model?.Arg ?? "{}");
            var result = InvokeDynamic(data);
            return result.GetCode(false, false);
        }

        //[HttpGet]
        //public string Get([FromBody] RequestBody? model = null)
        //{
        //    return string.Empty;
        //}

        //[HttpOptions]
        //public string Options([FromBody] RequestBody? model = null)
        //{
        //    return string.Empty;
        //}
    }


}
