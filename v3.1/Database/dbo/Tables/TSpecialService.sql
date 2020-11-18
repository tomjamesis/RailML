CREATE TABLE [dbo].[TSpecialService]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSpecialServiceId]		BIGINT		NOT NULL,
	[Type]						SMALLINT		NOT NULL,
	[SingleDateValue]			DATETIME		NOT NULL,
	[SingleDateValueSpecified]	BIT			NOT NULL,
	[StartDateValue]			DATETIME		NOT NULL,
	[StartDateValueSpecified]	BIT			NOT NULL,
	[EndDateValue]				DATETIME		NOT NULL,
	[EndDateValueSpecified]	BIT			NOT NULL,
	[StartTimeValue]			DATETIME		NOT NULL,
	[StartTimeValueSpecified]	BIT			NOT NULL,
	[EndTimeValue]				DATETIME		NOT NULL,
	[EndTimeValueSpecified]	BIT			NOT NULL,

	CONSTRAINT [PK_TSpecialServiceId] PRIMARY KEY CLUSTERED ([TSpecialServiceId] ASC),
	CONSTRAINT [FK_TSpecialService_Type] FOREIGN KEY ([Type]) REFERENCES [dbo].[Type] ([TypeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
