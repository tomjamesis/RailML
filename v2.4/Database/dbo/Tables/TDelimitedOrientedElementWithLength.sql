CREATE TABLE [dbo].[TDelimitedOrientedElementWithLength]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TDelimitedOrientedElementWithLengthId]	SMALLINT		NOT NULL,
	[DirValue]								TINYINT		NOT NULL,
	[DirValueSpecified]					BIT			NOT NULL,

	CONSTRAINT [PK_TDelimitedOrientedElementWithLengthId] PRIMARY KEY CLUSTERED ([TDelimitedOrientedElementWithLengthId] ASC),
	CONSTRAINT [FK_TDelimitedOrientedElementWithLength_TDelimitedDirection] FOREIGN KEY ([DirValue]) REFERENCES [dbo].[TDelimitedDirection] ([TDelimitedDirectionId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
