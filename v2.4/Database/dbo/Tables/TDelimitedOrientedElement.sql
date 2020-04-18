CREATE TABLE [dbo].[TDelimitedOrientedElement]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TDelimitedOrientedElementId]	SMALLINT		NOT NULL,
	[DirValue]					TINYINT		NOT NULL,
	[DirValueSpecified]		BIT			NOT NULL,

	CONSTRAINT [PK_TDelimitedOrientedElementId] PRIMARY KEY CLUSTERED ([TDelimitedOrientedElementId] ASC),
	CONSTRAINT [FK_TDelimitedOrientedElement_TDelimitedDirection] FOREIGN KEY ([DirValue]) REFERENCES [dbo].[TDelimitedDirection] ([TDelimitedDirectionId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
