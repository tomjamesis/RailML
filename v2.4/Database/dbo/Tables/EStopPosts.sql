CREATE TABLE [dbo].[EStopPosts]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EStopPostsId]	BIGINT		NOT NULL,
	[StopPost]		SMALLINT		NOT NULL,

	CONSTRAINT [PK_EStopPostsId] PRIMARY KEY CLUSTERED ([EStopPostsId] ASC),
	CONSTRAINT [FK_EStopPosts_TStopPost] FOREIGN KEY ([StopPost]) REFERENCES [dbo].[TStopPost] ([TStopPostId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
