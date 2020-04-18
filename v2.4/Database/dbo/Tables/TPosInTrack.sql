CREATE TABLE [dbo].[TPosInTrack]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TPosInTrackId]	TINYINT		NOT NULL,
	[Value]		NVARCHAR(16)	NOT NULL,

	CONSTRAINT [PK_TPosInTrackId] PRIMARY KEY CLUSTERED ([TPosInTrackId] ASC)
);
