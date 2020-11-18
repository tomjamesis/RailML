CREATE TABLE [dbo].[EGradientChanges]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EGradientChangesId]	BIGINT		NOT NULL,
	[GradientChange]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EGradientChangesId] PRIMARY KEY CLUSTERED ([EGradientChangesId] ASC),
	CONSTRAINT [FK_EGradientChanges_TGradientChange] FOREIGN KEY ([GradientChange]) REFERENCES [dbo].[TGradientChange] ([TGradientChangeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
