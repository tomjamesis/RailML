CREATE TABLE [dbo].[ETractionMotor]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETractionMotorId]	SMALLINT		NOT NULL,
	[Efficiency]		SMALLINT		NOT NULL,
	[MechanicalLosses]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ETractionMotorId] PRIMARY KEY CLUSTERED ([ETractionMotorId] ASC),
	CONSTRAINT [FK_ETractionMotor_TEfficiencyCurve] FOREIGN KEY ([Efficiency]) REFERENCES [dbo].[TEfficiencyCurve] ([TEfficiencyCurveId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETractionMotor_TLosses] FOREIGN KEY ([MechanicalLosses]) REFERENCES [dbo].[TLosses] ([TLossesId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
