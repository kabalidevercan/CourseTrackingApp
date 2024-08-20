namespace CourseTrackingApp.Controllers {

    public class OgrenciController: Controller {


        private readonly DataContext _context
    
        public OgrenciController(DataContext context){
            _context = context
        }

        public IActionResult Create(){  
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Ogrenci model){
            _context.Ogrenciler.Add(model)
            await _context.SaveChangesAsync();
            return RedirectToAction("Index")
        }

        public async Task<IActionResult> Index(){
            var ogrenciler = await _context.Ogrenciler.ToListAsync()
            return View(ogrenciler);
        }
    }


}