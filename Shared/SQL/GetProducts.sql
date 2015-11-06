

CREATE PROCEDURE GetProducts 
( 
    @OrderBy      VARCHAR(50), 
    @Input2       VARCHAR(30) 
) 
AS 
BEGIN 
    SET NOCOUNT ON 

    SELECT ProductID, ProductName, UnitPrice, UnitsInStock
    FROM Products 
    WHERE ProductName LIKE @Input2+'%'
    ORDER BY 
        CASE             
            WHEN @OrderBy = 'ProductNameAsc' THEN ProductName 
        END ASC, 
        CASE 
            WHEN @OrderBy = 'ProductNameDesc' THEN ProductName 
        END DESC, 
		 CASE             
            WHEN @OrderBy = 'UnitPriceAsc' THEN UnitPrice
        END ASC, 
        CASE 
            WHEN @OrderBy = 'UnitPriceDesc' THEN UnitPrice
        END DESC 
END;