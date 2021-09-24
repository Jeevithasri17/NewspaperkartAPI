using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewspaperkartAPI.CTSModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperkartAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        public static NewspaperkartContext db = new NewspaperkartContext();

        [HttpGet]

        public async Task<IActionResult> GetAllSubscriptions()
        {
            return Ok(await db.Customers.ToListAsync());
        }

        [HttpPost]

        public async Task<IActionResult> AddSubscription(Customer e)
        {
            db.Customers.Add(e);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSubscription(int id, Customer e)
        {
            db.Entry(e).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSubscription(int id)
        {
            Customer e = db.Customers.Find(id);
            db.Customers.Remove(e);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        [Route("GetSubscriptionByID")]
        public async Task<ActionResult<Customer>> GetSubscriptionById(int id)
        {
            Customer e = await db.Customers.FindAsync(id);
            return Ok(e);
        }
    }
}
