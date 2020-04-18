CREATE TABLE [dbo].[EElectricalCoupler]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EElectricalCouplerId]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EElectricalCouplerId] PRIMARY KEY CLUSTERED ([EElectricalCouplerId] ASC)
);
