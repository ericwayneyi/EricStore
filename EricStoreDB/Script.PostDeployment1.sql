/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

insert into Product(ID, Name, Price,[Description] , CanPurchase, SoldOut)
Values 
(1, 'Cole Haan', 125.00, 'Modern classic shoes fit for a tailored suit or denim
 and a blazer for a night out on the town.
 Provides maximum comfort.', 1, 0),
 (2, 'Nike', 99.99, 'Comfortable running shoes which provides 
 maximum arch support and breathability.', 1, 0),
 (3, 'Adidas Superstar', 69.99, 'Full grain leather with classic rubber shell with toe.',
 1, 0),
 (4, 'Pumas', 98.99, 'All smooth suede, streetwise swagger, and sport-inspired style', 1, 0),
 (5, 'Converse Chuck Taylors', 59.99, 'These unisex Converse All Star shoes are a must-have for your wardrobe', 1, 0),
 (6, 'Madden', 89.99, 'Provides handsome urban styles that go great with everything from denim to suits, and
  function equally well for a business lunch or an after-work dinner date', 1, 0),
 (7, 'Reebok', 69.99, 'Reebok shoes can help improve your game, whether it is walking to the subway, training 
 for that half-marathon or stepping it up in aerobics class.', 1, 0),
 (8, 'A K Anne Klein', 139.99, 'Designed for women who want a shoe that transitions seamlessly from office
  appropriate to Saturday night sexy', 1, 0),
 (9, 'Air Jordans', 249.99, 'The Air Jordan XIV co-styled by the famous Tinker Hatfield and Mark Smith', 1, 0),
 (10, 'Birkenstock', 79.99, 'Ensuring proper weight distribution and promoting proper posture,
  Birkenstock shoes benefit your entire body', 1, 0),
 (11, 'Clarks', 89.99, 'A casual classic, made better than ever with modern comfort features for all-day wear', 1, 0),
 (12, 'UGG', 199.99, 'One of the most popular silhouettes by UGG™ now pre-treated to repel water and stains', 1, 0)

