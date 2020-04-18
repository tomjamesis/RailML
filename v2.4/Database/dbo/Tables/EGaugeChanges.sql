CREATE TABLE [dbo].[EGaugeChanges]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EGaugeChangesId]	BIGINT		NOT NULL,
	[GaugeChange]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EGaugeChangesId] PRIMARY KEY CLUSTERED ([EGaugeChangesId] ASC),
	CONSTRAINT [FK_EGaugeChanges_TGaugeChange] FOREIGN KEY ([GaugeChange]) REFERENCES [dbo].[TGaugeChange] ([TGaugeChangeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
