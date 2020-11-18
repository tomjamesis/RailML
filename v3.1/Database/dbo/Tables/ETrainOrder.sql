CREATE TABLE [dbo].[ETrainOrder]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrainOrderId]	BIGINT		NOT NULL,
	[VehicleRef]	BIGINT		NOT NULL,

	CONSTRAINT [PK_ETrainOrderId] PRIMARY KEY CLUSTERED ([ETrainOrderId] ASC),
	CONSTRAINT [FK_ETrainOrder_TVehicleRef] FOREIGN KEY ([VehicleRef]) REFERENCES [dbo].[TVehicleRef] ([TVehicleRefId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
