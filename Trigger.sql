CREATE OR ALTER TRIGGER [AfterInsertUpdateNivel]
ON [Compras]
AFTER INSERT
AS
    DECLARE
    @Quant int,
    @CliCpf NVARCHAR(450)

    SELECT @Quant = Quantidade, @CliCpf = ClientCPF FROM INSERTED

    UPDATE [Clients] SET QuantidadeCompras = QuantidadeCompras+1 Where CPF = @CliCpf;
    SELECT @Quant = (SELECT QuantidadeCompras FROM [Clients] WHERE CPF = @CliCpf);
    EXEC Nivel @Quant,@CliCpf

    --CORPO DO TRIGGER