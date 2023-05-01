//using Microsoft.EntityFrameworkCore;
//using Urban.Models;

//namespace Urban.Data.Services
//{
//    public class ProductService : IProductService
//    {
//        public Task<IEnumerable<Product>> GetProductsAsync(int cId)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<Product> UpdateCandidate(int pId, Product product)
//        {
//            throw new NotImplementedException();
//        }

//        public class productService : EntityBaseRepository<Product>, IProductService
//        {
//            private readonly ApplicationDbContext _context;
//            public productService(ApplicationDbContext context) : base(context)
//            {
//                _context = context;
//            }

//            public async Task<IEnumerable<Product>> GetProductAsync(int cId)
//            {
//                var results = await _context.Product.Where(p => p.Id == cId).ToListAsync();

//                return results;
//            }

//            public Task<IEnumerable<Product>> GetProductsAsync(int cId)
//            {
//                throw new NotImplementedException();
//            }

//            public async Task<Product> UpdateCandidate(int id, Product product)
//            {
//                Product c = await _context.Product.FindAsync(id);

//                c.ProductName = product.ProductName;
//                c.ProductDescrition = product.ProductDescrition;
//                c.Productprice = product.Productprice;
//                c.ProductImage = product.ProductImage;
//                _context.Attach(c);
//                _context.Entry(c).State = EntityState.Modified;
//                _context.SaveChanges();
//                return c;
//            }
//        }
//    }
//}