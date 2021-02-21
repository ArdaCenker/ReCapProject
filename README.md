# :red_car: :blue_car: ReCapProject (Araç Kiralama Sistemi) :blue_car: :red_car:
##### Bu proje Engin Demiroğ'un "Nitelikli" Yazılım Geliştirici Geliştirme Kampı genel tekrar ödevi olarak hazırlanmıştır.

# :books: Layers
## :books: **Entities**
  * :open_file_folder: ~~Abstract~~
  * :open_file_folder: Concrete
    * :bookmark_tabs: [Car.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/Concrete/Car.cs)
    * :bookmark_tabs: [Brand.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/Concrete/Brand.cs)
    * :bookmark_tabs: [Color.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/Concrete/Color.cs)
    * :bookmark_tabs: [User.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/Concrete/User.cs)
    * :bookmark_tabs: [Customer.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/Concrete/Customer.cs)
    * :bookmark_tabs: [Rental.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/Concrete/Rental.cs)
  * :open_file_folder: DTO's
    * :bookmark_tabs: [CarDetailDto.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/DTOs/CarDetailDto.cs)
    * :bookmark_tabs: [RentalDetailDto.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/DTOs/RentalDetailDto.cs)
    
## :books: **DataAccess**
  * :open_file_folder: Abstract
    * :bookmark_tabs: [ICarDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Abstract/ICarDal.cs)
    * :bookmark_tabs: [IBrandDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Abstract/IBrandDal.cs)
    * :bookmark_tabs: [IColorDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Abstract/IColorDal.cs)
    * :bookmark_tabs: [IUserDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Abstract/IUserDal.cs)
    * :bookmark_tabs: [ICustomerDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Abstract/ICustomerDal.cs)
    * :bookmark_tabs: [IRentalDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Abstract/IRentalDal.cs)
  * :open_file_folder: Concrete
    * :open_file_folder: EntityFramework
      * :bookmark_tabs: [EfCarDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Concrete/EntityFramework/EfCarDal.cs)
      * :bookmark_tabs: [EfBrandDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Concrete/EntityFramework/EfBrandDal.cs)
      * :bookmark_tabs:[EfColorDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Concrete/EntityFramework/EfColorDal.cs)
      * :bookmark_tabs: [EfUserDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Concrete/EntityFramework/EfUserDal.cs)
      * :bookmark_tabs: [EfCustomerDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Concrete/EntityFramework/EfCustomerDal.cs)
      * :bookmark_tabs: [EfRentalDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Concrete/EntityFramework/EfRentalDal.cs)
      * :bookmark_tabs: [RentACarDbContext.cs](https://github.com/ArdaCenker/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/RentACarDbContext.cs)
    * :open_file_folder: ~~InMemory~~
  
## :books: **Business**
  * :open_file_folder: Abstract
    * :bookmark_tabs: [ICarService.cs](https://github.com/]ArdaCenker/ReCapProject/tree/master/Business/Abstract/ICarService.cs)
    * :bookmark_tabs: [IBrandService.cs](https://github.com/]ArdaCenker/ReCapProject/tree/master/Business/Abstract/IBrandService.cs)
    * :bookmark_tabs: [IColorService.cs](https://github.com/]ArdaCenker/ReCapProject/tree/master/Business/Abstract/IColorService.cs)
    * :bookmark_tabs: [IUserService.cs](https://github.com/]ArdaCenker/ReCapProject/tree/master/Business/Abstract/IUserService.cs)
    * :bookmark_tabs: [ICustomerService.cs](https://github.com/]ArdaCenker/ReCapProject/tree/master/Business/Abstract/ICustomerService.cs)
    * :bookmark_tabs: [IRentalService.cs](https://github.com/]ArdaCenker/ReCapProject/tree/master/Business/Abstract/IRentalService.cs)
  * :open_file_folder: Concrete
    * :bookmark_tabs: [CarManager.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/Concrete/CarManager.cs)
    * :bookmark_tabs: [BrandManager.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/Concrete/BrandManager.cs)
    * :bookmark_tabs: [ColorManager.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/Concrete/ColorManager.cs)
    * :bookmark_tabs: [UserManager.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/Concrete/UserManager.cs)
    * :bookmark_tabs: [CustomerManager.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/Concrete/CustomerManager.cs)
    * :bookmark_tabs:[RentalManager.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/Concrete/RentalManager.cs)
  * :open_file_folder: Constants
    * :bookmark_tabs: [Messages.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/Constants/Messages.cs)
  * :open_file_folder: DependencyResolvers
    * :open_file_folder: Autofac
      * :bookmark_tabs: [AutofacBusinessModule.cs](https://github.com/ArdaCenker/ReCapProject/blob/master/Business/DependencyResolvers/Autofac/AutofacBusinessModule.cs)
  * :open_file_folder: ValidationRules
    * :open_file_folder: FluentValidation
      * :bookmark_tabs: [CarValidator.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/ValidationRules/FluentValidation/CarValidator.cs)
      * :bookmark_tabs: [BrandValidator.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/ValidationRules/FluentValidation/BrandValidator.cs)
      * :bookmark_tabs: [ColorValidator.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/ValidationRules/FluentValidation/ColorValidator.cs)
      * :bookmark_tabs: [UserValidator.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/ValidationRules/FluentValidation/UserValidator.cs)
      * :bookmark_tabs: [CustomerValidator.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/ValidationRules/FluentValidation/CustomerValidator.cs)
      * :bookmark_tabs: [RentalValidator.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/ValidationRules/FluentValidation/RentalValidator.cs)
  
## :books: **Core**
  * :open_file_folder: Aspects
    * :open_file_folder: Autofac
      * :open_file_folder: Validation
        * :bookmark_tabs: [ValidationAspect.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Aspects/Autofac/Validation/ValidationAspect.cs)
  * :open_file_folder: CrossCuttingConcerns
    * :open_file_folder: Validation
      * :bookmark_tabs: [ValidationTool.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/CrossCuttingConcerns/Validation/ValidationTool.cs)
  * :open_file_folder: DataAccess
    * :open_file_folder: EntityFramework
      * :bookmark_tabs: [EfEntityRepositoryBase.cs](https://github.com/ArdaCenker/ReCapProject/blob/master/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs)
    * :bookmark_tabs: [IEntityRepository.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/DataAccess/IEntityRepository.cs)
  * :open_file_folder: Entities
    * :bookmark_tabs:[IEntity.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Entities/IEntity.cs)
    * :bookmark_tabs: [IDto.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Entities/IDto.cs)
  * :open_file_folder: Utilities
    * :open_file_folder: Interceptors
      * :bookmark_tabs: [AspectInterceptorSelector.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Interceptors/AspectInterceptorSelector.cs)
      * :bookmark_tabs: [MethodInterception.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Interceptors/MethodInterception.cs)
      * :bookmark_tabs: [MethodInterceptionBaseAttribute.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Interceptors/MethodInterceptionBaseAttribute.cs)
    * :open_file_folder: Results
      * :bookmark_tabs: [IResult.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Results/IResult.cs)
      * :bookmark_tabs: [Result.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Results/Result.cs)
      * :bookmark_tabs: [SuccessResult.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Results/SuccessResult.cs)
      * :bookmark_tabs: [ErrorResult.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Results/ErrorResult.cs)
      * :bookmark_tabs: [IDataResult.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Results/IDataResult.cs)
      * :bookmark_tabs: [DataResult.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Results/DataResult.cs)
      * :bookmark_tabs: [SuccessDataResult.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Results/SuccessDataResult.cs)
      * :bookmark_tabs: [ErrorDataResult.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Results/ErrorDataResult.cs)
  
## :books: **ConsoleUI (Test Ortamı)**
  * :bookmark_tabs: ~~Program.cs~~
  
## :books: **WebAPI**
  * :open_file_folder: Controllers
    * :bookmark_tabs: [CarsController.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/WebAPI/Controllers/CarsController.cs)
    * :bookmark_tabs: [BrandsController.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/WebAPI/Controllers/BrandsController.cs)
    * :bookmark_tabs: [ColorsController.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/WebAPI/Controllers/ColorsController.cs)
    * :bookmark_tabs: [UsersController.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/WebAPI/Controllers/UsersController.cs)
    * :bookmark_tabs: [CustomersController.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/WebAPI/Controllers/CustomersController.cs)
    * :bookmark_tabs: [RentalsController.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/WebAPI/Controllers/RentalsController.cs)
  * :bookmark_tabs: [Program.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/WebAPI/Program.cs)
  * :bookmark_tabs: [Startup.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/WebAPI/Startup.cs)


## **Database Tables And SQL File**
