CREATE TABLE [dbo].[TClearanceGaugeChange]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TClearanceGaugeChangeId]	SMALLINT		NOT NULL,
	[ClearanceGauge]		BIGINT		NOT NULL,

	CONSTRAINT [PK_TClearanceGaugeChangeId] PRIMARY KEY CLUSTERED ([TClearanceGaugeChangeId] ASC),
	CONSTRAINT [FK_TClearanceGaugeChange_TClearanceGaugeType] FOREIGN KEY ([ClearanceGauge]) REFERENCES [dbo].[TClearanceGaugeType] ([TClearanceGaugeTypeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
