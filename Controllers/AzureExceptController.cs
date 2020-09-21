namespace myWebApp42.Controllers
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using myWebApp42.Models;

    public class AzureExceptionController : Controller
    {
        private readonly ICosmosDbService _cosmosDbService;
        public AzureExceptionController(ICosmosDbService cosmosDbService)
        {
            _cosmosDbService = cosmosDbService;
        }

        [ActionName("Index")]
        public async Task<IActionResult> Index()
        {
            return View(await _cosmosDbService.GetAzureExceptionsAsync("SELECT * FROM c"));
        }

        [ActionName("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync([Bind("Id,Prio,PartitionKey,Active,Code,Result,Context,ReturnCode,ReturnResult,ReturnDetails,ReturnType")] AzureException AzureException)
        {
            if (ModelState.IsValid)
            {
                AzureException.Id = Guid.NewGuid().ToString();
                await _cosmosDbService.AddAzureExceptionAsync(AzureException);
                return RedirectToAction("Index");
            }

            return View(AzureException);
        }

        [HttpPost]
        [ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync([Bind("Id,Prio,PartitionKey,Active,Code,Result,Context,ReturnCode,ReturnResult,ReturnDetails,ReturnType")] AzureException AzureException)
        {
            if (ModelState.IsValid)
            {
                await _cosmosDbService.UpdateAzureExceptionAsync(AzureException.Id, AzureException);
                return RedirectToAction("Index");
            }

            return View(AzureException);
        }

        [ActionName("Edit")]
        public async Task<ActionResult> EditAsync(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            AzureException AzureException = await _cosmosDbService.GetAzureExceptionAsync(id);
            if (AzureException == null)
            {
                return NotFound();
            }

            return View(AzureException);
        }

        [ActionName("Delete")]
        public async Task<ActionResult> DeleteAsync(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            AzureException AzureException = await _cosmosDbService.GetAzureExceptionAsync(id);
            if (AzureException == null)
            {
                return NotFound();
            }

            return View(AzureException);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmedAsync([Bind("Id")] string id)
        {
            await _cosmosDbService.DeleteAzureExceptionAsync(id);
            return RedirectToAction("Index");
        }

        [ActionName("Details")]
        public async Task<ActionResult> DetailsAsync(string id)
        {
            return View(await _cosmosDbService.GetAzureExceptionAsync(id));
        }
    }
}

