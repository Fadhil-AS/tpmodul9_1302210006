using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmodul9_1302210006.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mahasiswa1302210006Controller : ControllerBase
    {
        private static List<Mahasiswa_1302210006> mhsList = new List<Mahasiswa_1302210006>()
        {
            new Mahasiswa_1302210006("Muhammad Fadhil Ardiansyah Supiyan", "1302210006"),
            new Mahasiswa_1302210006("Muhammad Vikhan Muharram", "1302213089"),
            new Mahasiswa_1302210006("Heru Ikhsan Maulana", "1302210009"),
            new Mahasiswa_1302210006("Bimo Zachriansyah Wicaksono Hermawan", "1302213012"),
            new Mahasiswa_1302210006("Faris Siddiq Ramdan Putra", "1302213133")
        };

        // GET: api/<Mahasiswa1302210006>
        [HttpGet]
        public IEnumerable<Mahasiswa_1302210006> Get()
        {
            return mhsList;
        }

        // GET api/<Mahasiswa1302210006>/5
        [HttpGet("{id}")]
        public Mahasiswa_1302210006 Get(int id)
        {
            return mhsList[id];
        }

        // POST api/<Mahasiswa1302210006>
        [HttpPost]
        public void Post([FromBody] Mahasiswa_1302210006 value)
        {
            mhsList.Add(value);
        }

        // PUT api/<Mahasiswa1302210006>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa_1302210006 value)
        {
            //mhsList[id] = value;
        }

        // DELETE api/<Mahasiswa1302210006>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mhsList.RemoveAt(id);
        }
    }
}
