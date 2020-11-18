CREATE TABLE [dbo].[EPowerTransmissionChanges]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EPowerTransmissionChangesId]	BIGINT		NOT NULL,
	[PowerTransmissionChange]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EPowerTransmissionChangesId] PRIMARY KEY CLUSTERED ([EPowerTransmissionChangesId] ASC),
	CONSTRAINT [FK_EPowerTransmissionChanges_TPowerTransmissionChange] FOREIGN KEY ([PowerTransmissionChange]) REFERENCES [dbo].[TPowerTransmissionChange] ([TPowerTransmissionChangeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
