USE [391Project]

---Add to Cart---
GO
CREATE PROC addToCart
    @SID INT,
    @SecID INT
AS
BEGIN
	BEGIN Try
		BEGIN Transaction
			INSERT INTO Cart (SID, SecID) 
			VALUES (@SID, @SecID)
		COMMIT Transaction
	END Try
	BEGIN Catch
		Rollback Transaction
	END Catch
END
GO
---Delete from Cart---
GO
CREATE PROC deleteFromCart
    @SID INT,
    @SecID INT
AS
BEGIN
	BEGIN Try
		BEGIN Transaction
			IF EXISTS(SELECT 1 FROM Cart WHERE SID = @SID AND SecID = @SecID)
			BEGIN
				DELETE FROM Cart WHERE SID = @SID AND SecID = @SecID
			END
		COMMIT Transaction
	END Try
	BEGIN Catch
		Rollback Transaction
	END Catch
END
GO