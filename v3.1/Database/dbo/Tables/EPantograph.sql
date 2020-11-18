CREATE TABLE [dbo].[EPantograph]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EPantographId]		SMALLINT		NOT NULL,
	[DedicatedSupplySystem]	BIGINT		NOT NULL,

	CONSTRAINT [PK_EPantographId] PRIMARY KEY CLUSTERED ([EPantographId] ASC),
	CONSTRAINT [FK_EPantograph_TElectrificationSystem] FOREIGN KEY ([DedicatedSupplySystem]) REFERENCES [dbo].[TElectrificationSystem] ([TElectrificationSystemId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
