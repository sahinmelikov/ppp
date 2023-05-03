using Task04._28._23.Models;
using Task04._28._23.Services.BaseeNTITY;
using Task04._28._23.Services.Implementations.Restaurant;
using Task04._28._23.Services.Interfaces.ProductInterface;

Product aa=new Product();
BaseEntity hh=new BaseEntity();
aa.Id = 1;
aa.Name = "ss";
BaseEntity hh1 = new BaseEntity();
hh1.Id= 2;
IProductInterface rest=new IProductInterface();

rest.GetById(2);
rest.Update("aa");