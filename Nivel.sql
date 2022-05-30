SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [Nivel]  
    @Quant int,
    @cpf  NVARCHAR(450)
AS
BEGIN
   IF @Quant >=0 and @Quant<= 10 
     UPDATE [Clients] SET Nivel=1 WHERE CPF = @cpf ;
   ELSE IF @Quant >10 and @Quant<= 20 
     UPDATE [Clients] SET Nivel=2 WHERE CPF = @cpf ;
   ELSE IF @Quant > 20 
     UPDATE [Clients] SET Nivel=3 WHERE CPF = @cpf ;
END
GO