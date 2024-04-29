//using Core.Interfaces.Services;
//using Core.Request;
//using Microsoft.AspNetCore.Mvc;
//using System.Threading.Tasks;

//namespace WebApi.Controllers
//{
//    public class TransferController : BaseApiController
//    {
//        private readonly ITransferService _service;

//        public TransferController(ITransferService service)
//        {
//            _service = service;
//        }

//        [HttpPost]
//        public async Task<IActionResult> Create([FromBody] CreateTransferModel request)
//        {
//            return Ok(await _service.Add(request));
//        }

//        [HttpGet("{id}")]
//        public async Task<IActionResult> GetById([FromRoute] int id)
//        {
//            var transfer = await _service.GetById(id);
//            return Ok(transfer);
//        }

//        [HttpPut]
//        public async Task<IActionResult> Update([FromBody] UpdateTransferModel request)
//        {
//            return Ok(await _service.Update(request));
//        }

//        [HttpDelete("{id}")]
//        public async Task<IActionResult> Delete([FromRoute] int id)
//        {
//            return Ok(await _service.Delete(id));
//        }

//        [HttpGet("all")]
//        public async Task<IActionResult> GetAll()
//        {
//            var transfers = await _service.GetAll();
//            return Ok(transfers);
//        }
//    }
//}
