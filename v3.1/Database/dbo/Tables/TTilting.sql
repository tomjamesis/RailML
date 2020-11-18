CREATE TABLE [dbo].[TTilting]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTiltingId]					BIGINT		NOT NULL,
	[MaxTiltingAngleValue]			DECIMAL(18, 6)	NOT NULL,
	[MaxTiltingAngleValueSpecified]	BIT			NOT NULL,
	[ActuationValue]				TINYINT		NOT NULL,
	[ActuationValueSpecified]		BIT			NOT NULL,
	[TiltingSpeedValue]			DECIMAL(18, 6)	NOT NULL,
	[TiltingSpeedValueSpecified]	BIT			NOT NULL,

	CONSTRAINT [PK_TTiltingId] PRIMARY KEY CLUSTERED ([TTiltingId] ASC),
	CONSTRAINT [FK_TTilting_TTiltingActuationType] FOREIGN KEY ([ActuationValue]) REFERENCES [dbo].[TTiltingActuationType] ([TTiltingActuationTypeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
