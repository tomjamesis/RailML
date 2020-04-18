CREATE TABLE [dbo].[EClearanceGaugeChanges]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EClearanceGaugeChangesId]	BIGINT		NOT NULL,
	[ClearanceGaugeChange]		SMALLINT		NOT NULL,

	CONSTRAINT [PK_EClearanceGaugeChangesId] PRIMARY KEY CLUSTERED ([EClearanceGaugeChangesId] ASC),
	CONSTRAINT [FK_EClearanceGaugeChanges_TClearanceGaugeChange] FOREIGN KEY ([ClearanceGaugeChange]) REFERENCES [dbo].[TClearanceGaugeChange] ([TClearanceGaugeChangeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
