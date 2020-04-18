CREATE TABLE [dbo].[ETrackBegin]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrackBeginId]		SMALLINT		NOT NULL,
	[AbsDirValue]			TINYINT		NOT NULL,
	[AbsDirValueSpecified]	BIT			NOT NULL,

	CONSTRAINT [PK_ETrackBeginId] PRIMARY KEY CLUSTERED ([ETrackBeginId] ASC),
	CONSTRAINT [FK_ETrackBegin_TMileageDirection] FOREIGN KEY ([AbsDirValue]) REFERENCES [dbo].[TMileageDirection] ([TMileageDirectionId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
