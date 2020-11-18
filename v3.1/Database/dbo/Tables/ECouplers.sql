CREATE TABLE [dbo].[ECouplers]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ECouplersId]		BIGINT		NOT NULL,
	[MechanicalCoupler]	SMALLINT		NOT NULL,
	[PneumaticCoupler]	SMALLINT		NOT NULL,
	[ElectricalCoupler]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ECouplersId] PRIMARY KEY CLUSTERED ([ECouplersId] ASC),
	CONSTRAINT [FK_ECouplers_EMechanicalCoupler] FOREIGN KEY ([MechanicalCoupler]) REFERENCES [dbo].[EMechanicalCoupler] ([EMechanicalCouplerId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ECouplers_EPneumaticCoupler] FOREIGN KEY ([PneumaticCoupler]) REFERENCES [dbo].[EPneumaticCoupler] ([EPneumaticCouplerId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ECouplers_EElectricalCoupler] FOREIGN KEY ([ElectricalCoupler]) REFERENCES [dbo].[EElectricalCoupler] ([EElectricalCouplerId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
