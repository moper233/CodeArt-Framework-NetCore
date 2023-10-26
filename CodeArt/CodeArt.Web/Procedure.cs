using CodeArt.DTO;
using Microsoft.AspNetCore.Mvc;

namespace CodeArt.Web
{
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

        //[HttpGet]
        //public string Get(string arg)
        //{
        //    var data = DTObject.Create(arg);
        //    var result = this.InvokeDynamic(data);
        //    return result.GetCode(false, false);
        //}


        [HttpPost]
        public string Post(string arg)
        {
            var data = DTObject.Create(arg);
            var result = InvokeDynamic(data);
            return result.GetCode(false, false);
        }
    }


}
