CREATE TABLE [dbo].[EElectrificationChanges]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EElectrificationChangesId]	BIGINT		NOT NULL,
	[ElectrificationChange]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EElectrificationChangesId] PRIMARY KEY CLUSTERED ([EElectrificationChangesId] ASC),
	CONSTRAINT [FK_EElectrificationChanges_TElectrificationChange] FOREIGN KEY ([ElectrificationChange]) REFERENCES [dbo].[TElectrificationChange] ([TElectrificationChangeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
