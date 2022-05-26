CREATE OR ALTER PROCEDURE InsertData  
    @Cod int,
    @TipoPag NVARCHAR(MAX) = NULL,
    @Quant int = NULL,
    @CPFCLi NVARCHAR(450) = NULL,
    @IDCorreio int = NULL,
    @IDProd int = NULL
AS
BEGIN TRY
    IF(@IDCorreio = NUll)
        RAISERROR('Compra não realizada, Frete não disponível',16,1);
    
    IF(@CPFCLi = NUll or @IDProd = NULL)
        RAISERROR('Compra não realizada, CPF ou Produto inválido',16,1);
    IF (SELECT Quant From Products WHERE(Id = @IDProd)) < @Quant 
          RAISERROR('Compra não realizada, quantidade insuficiente',16,1);

    DECLARE @total float = ((Select Preco From Products Where(Id = @IDProd)) * @Quant)

    INSERT INTO Compras (Cod,ValorTotal,Pagamento,Quantidade,ClientCPF,CorreioId,ProductId) 
    VALUES (@Cod,@total,@TipoPag,@Quant,@CPFCLi,@IDCorreio,@IDProd);
    
    IF (SELECT Quant From Products WHERE(Id = @IDProd)) < 0 
         RAISERROR('O Estoque está vazio',16,1);
    UPDATE  [Products]  SET Quant = (Quant - @Quant) WHERE Id = @IDProd ;

    PRINT('Compra realizada com sucesso');  
END TRY
BEGIN CATCH
    SELECT ERROR_MESSAGE(), ERROR_SEVERITY();
END CATCH