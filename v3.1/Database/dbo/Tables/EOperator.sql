CREATE TABLE [dbo].[EOperator]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EOperatorId]			SMALLINT		NOT NULL,
	[VehicleIdentification]	BIGINT		NOT NULL,

	CONSTRAINT [PK_EOperatorId] PRIMARY KEY CLUSTERED ([EOperatorId] ASC),
	CONSTRAINT [FK_EOperator_TVehicleIdentification] FOREIGN KEY ([VehicleIdentification]) REFERENCES [dbo].[TVehicleIdentification] ([TVehicleIdentificationId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
