CREATE TABLE [dbo].[Publisher]
(
	--From MergedXSDs XSD
	--From 'Dc_Elements' Namespace
	[PublisherId]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_PublisherId] PRIMARY KEY CLUSTERED ([PublisherId] ASC)
);
