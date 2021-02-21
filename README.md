# ReCapProject (Araç Kiralama Sistemi)
##### Bu proje Engin Demiroğ'un "Nitelikli" Yazılım Geliştirici Geliştirme Kampı genel tekrar ödevi olarak hazırlanmıştır.

# Layers
## [Entities](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities)
  * ~~Abstract~~
  * [Concrete](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/Concrete)
    * [Car.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/Concrete/Car.cs)
    * [Brand.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/Concrete/Brand.cs)
    * [Color.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/Concrete/Color.cs)
    * [User.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/Concrete/User.cs)
    * [Customer.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/Concrete/Customer.cs)
    * [Rental.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/Concrete/Rental.cs)
  * [DTO's](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/DTOs)
    * [CarDetailDto.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/DTOs/CarDetailDto.cs)
    * [RentalDetailDto.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/Entities/DTOs/RentalDetailDto.cs)
    
## [DataAccess](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess)
  * [Abstract](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Abstract)
    * [ICarDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Abstract/ICarDal.cs)
    * [IBrandDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Abstract/IBrandDal.cs)
    * [IColorDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Abstract/IColorDal.cs)
    * [IUserDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Abstract/IUserDal.cs)
    * [ICustomerDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Abstract/ICustomerDal.cs)
    * [IRentalDal.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Abstract/IRentalDal.cs)
  * [Concrete](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Concrete)
    * [EntityFramework](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Concrete/EntityFramework)
      * [CarManager.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Concrete/EntityFramework/CarManager.cs)
      * [BrandManager.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Concrete/EntityFramework/BrandManager.cs)
      * [ColorManager.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Concrete/EntityFramework/ColorManager.cs)
      * [UserManager.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Concrete/EntityFramework/UserManager.cs)
      * [CustomerManager.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Concrete/EntityFramework/CustomerManager.cs)
      * [RentalManager.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/DataAccess/Concrete/EntityFramework/RentalManager.cs)
    * ~~InMemory~~
  
## [Business](https://github.com/ArdaCenker/ReCapProject/tree/master/Business)
  * [Abstract](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/Abstract)
  * [Concrete](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/Concrete)
  * [Constants](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/Constants)
  * [DependencyResolvers](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/DependencyResolvers)
  * [ValidationRules](https://github.com/ArdaCenker/ReCapProject/tree/master/Business/ValidationRules)
  
## [Core](https://github.com/ArdaCenker/ReCapProject/tree/master/Core)
  * [Aspects](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Aspects)
  * [CrossCuttingConcerns](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/CrossCuttingConcerns)
  * [DataAccess](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/DataAccess)
  * [Entities](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Entities)
  * [Utilities](https://github.com/ArdaCenker/ReCapProject/tree/master/Core/Utilities)
  
## [ConsoleUI (Test Ortamı)](https://github.com/ArdaCenker/ReCapProject/tree/master/ConsoleUI)
  * ~~Program.cs~~
  
## [WebAPI](https://github.com/ArdaCenker/ReCapProject/tree/master/WebAPI)
  * [Controllers](https://github.com/ArdaCenker/ReCapProject/tree/master/WebAPI/Controllers)
  * [Properties](https://github.com/ArdaCenker/ReCapProject/tree/master/WebAPI/Properties)
  * [Program.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/WebAPI/Program.cs)
  * [Startup.cs](https://github.com/ArdaCenker/ReCapProject/tree/master/WebAPI/Startup.cs)


## Database Tables And SQL File
