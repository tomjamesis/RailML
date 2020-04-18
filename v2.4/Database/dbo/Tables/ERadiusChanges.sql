CREATE TABLE [dbo].[ERadiusChanges]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ERadiusChangesId]	BIGINT		NOT NULL,
	[RadiusChange]		SMALLINT		NOT NULL,

	CONSTRAINT [PK_ERadiusChangesId] PRIMARY KEY CLUSTERED ([ERadiusChangesId] ASC),
	CONSTRAINT [FK_ERadiusChanges_TRadiusChange] FOREIGN KEY ([RadiusChange]) REFERENCES [dbo].[TRadiusChange] ([TRadiusChangeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
