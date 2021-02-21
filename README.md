# :red_car: :blue_car: ReCapProject (Araç Kiralama Sistemi) :blue_car: :red_car:
##### Bu proje Engin Demiroğ'un "Nitelikli" Yazılım Geliştirici Geliştirme Kampı genel tekrar ödevi olarak hazırlanmıştır.

# :books: Layers
## :books: **Entities**
  * :open_file_folder: ~~Abstract~~
  * :open_file_folder: Concrete
    * [Car.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/Concrete/Car.cs)
    * [Brand.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/Concrete/Brand.cs)
    * [Color.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/Concrete/Color.cs)
    * [User.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/Concrete/User.cs)
    * [Customer.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/Concrete/Customer.cs)
    * [Rental.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/Concrete/Rental.cs)
  * :open_file_folder: DTO's
    * [CarDetailDto.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/DTOs/CarDetailDto.cs)
    * [RentalDetailDto.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/DTOs/RentalDetailDto.cs)
    
## :books: **DataAccess**
  * :open_file_folder: Abstract
    * [ICarDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Abstract/ICarDal.cs)
    * [IBrandDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Abstract/IBrandDal.cs)
    * [IColorDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Abstract/IColorDal.cs)
    * [IUserDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Abstract/IUserDal.cs)
    * [ICustomerDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Abstract/ICustomerDal.cs)
    * [IRentalDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Abstract/IRentalDal.cs)
  * :open_file_folder: Concrete
    * :open_file_folder: EntityFramework
      * [EfCarDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Concrete/EntityFramework/EfCarDal.cs)
      * [EfBrandDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Concrete/EntityFramework/EfBrandDal.cs)
      * [EfColorDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Concrete/EntityFramework/EfColorDal.cs)
      * [EfUserDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Concrete/EntityFramework/EfUserDal.cs)
      * [EfCustomerDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Concrete/EntityFramework/EfCustomerDal.cs)
      * [EfRentalDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Concrete/EntityFramework/EfRentalDal.cs)
      * [RentACarDbContext.cs](https://github.com/ArdaCenker/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/RentACarDbContext.cs)
    * :open_file_folder: ~~InMemory~~
  
## :books: **Business**
  * :open_file_folder: Abstract
    * [ICarService.cs](https://github.com/]ArdaCenker/ReCapProject/tree/master/Business/Abstract/ICarService.cs)
    * [IBrandService.cs](https://github.com/]ArdaCenker/ReCapProject/tree/master/Business/Abstract/IBrandService.cs)
    * [IColorService.cs](https://github.com/]ArdaCenker/ReCapProject/tree/master/Business/Abstract/IColorService.cs)
    * [IUserService.cs](https://github.com/]ArdaCenker/ReCapProject/tree/master/Business/Abstract/IUserService.cs)
    * [ICustomerService.cs](https://github.com/]ArdaCenker/ReCapProject/tree/master/Business/Abstract/ICustomerService.cs)
    * [IRentalService.cs](https://github.com/]ArdaCenker/ReCapProject/tree/master/Business/Abstract/IRentalService.cs)
  * :open_file_folder: Concrete
    * [CarManager.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/Concrete/CarManager.cs)
    * [BrandManager.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/Concrete/BrandManager.cs)
    * [ColorManager.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/Concrete/ColorManager.cs)
    * [UserManager.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/Concrete/UserManager.cs)
    * [CustomerManager.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/Concrete/CustomerManager.cs)
    * [RentalManager.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/Concrete/RentalManager.cs)
  * :open_file_folder: Constants
    * [Messages.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/Constants/Messages.cs)
  * :open_file_folder: DependencyResolvers
    * :open_file_folder: Autofac
      * [AutofacBusinessModule.cs](https://github.com/ArdaCenker/ReCapProject/blob/master/Business/DependencyResolvers/Autofac/AutofacBusinessModule.cs)
  * :open_file_folder: ValidationRules
    * :open_file_folder: FluentValidation
      * [CarValidator.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/ValidationRules/FluentValidation/CarValidator.cs)
      * [BrandValidator.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/ValidationRules/FluentValidation/BrandValidator.cs)
      * [ColorValidator.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/ValidationRules/FluentValidation/ColorValidator.cs)
      * [UserValidator.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/ValidationRules/FluentValidation/UserValidator.cs)
      * [CustomerValidator.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/ValidationRules/FluentValidation/CustomerValidator.cs)
      * [RentalValidator.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/ValidationRules/FluentValidation/RentalValidator.cs)
  
## :books: **Core**
  * :open_file_folder: Aspects
    * :open_file_folder: Autofac
      * :open_file_folder: Validation
        * [ValidationAspect.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Aspects/Autofac/Validation/ValidationAspect.cs)
  * :open_file_folder: CrossCuttingConcerns
    * :open_file_folder: Validation
      * [ValidationTool.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/CrossCuttingConcerns/Validation/ValidationTool.cs)
  * :open_file_folder: DataAccess
    * :open_file_folder: EntityFramework
      * [EfEntityRepositoryBase.cs](https://github.com/ArdaCenker/ReCapProject/blob/master/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs)
    * [IEntityRepository.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/DataAccess/IEntityRepository.cs)
  * :open_file_folder: Entities
    * [IEntity.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Entities/IEntity.cs)
    * [IDto.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Entities/IDto.cs)
  * :open_file_folder: Utilities
    * :open_file_folder: Interceptors
      * [AspectInterceptorSelector.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Interceptors/AspectInterceptorSelector.cs)
      * [MethodInterception.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Interceptors/MethodInterception.cs)
      * [MethodInterceptionBaseAttribute.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Interceptors/MethodInterceptionBaseAttribute.cs)
    * :open_file_folder: Results
      * [IResult.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Results/IResult.cs)
      * [Result.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Results/Result.cs)
      * [SuccessResult.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Results/SuccessResult.cs)
      * [ErrorResult.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Results/ErrorResult.cs)
      * [IDataResult.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Results/IDataResult.cs)
      * [DataResult.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Results/DataResult.cs)
      * [SuccessDataResult.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Results/SuccessDataResult.cs)
      * [ErrorDataResult.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities/Results/ErrorDataResult.cs)
  
## :books: **ConsoleUI (Test Ortamı)**
  * ~~Program.cs~~
  
## :books: **WebAPI**
  * :open_file_folder: Controllers
    * [CarsController.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/WebAPI/Controllers/CarsController.cs)
    * [BrandsController.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/WebAPI/Controllers/BrandsController.cs)
    * [ColorsController.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/WebAPI/Controllers/ColorsController.cs)
    * [UsersController.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/WebAPI/Controllers/UsersController.cs)
    * [CustomersController.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/WebAPI/Controllers/CustomersController.cs)
    * [RentalsController.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/WebAPI/Controllers/RentalsController.cs)
  * [Program.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/WebAPI/Program.cs)
  * [Startup.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/WebAPI/Startup.cs)


## **Database Tables And SQL File**
