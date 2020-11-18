CREATE TABLE [dbo].[ECategories]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ECategoriesId]	BIGINT		NOT NULL,
	[Category]		SMALLINT		NOT NULL,

	CONSTRAINT [PK_ECategoriesId] PRIMARY KEY CLUSTERED ([ECategoriesId] ASC),
	CONSTRAINT [FK_ECategories_ECategory] FOREIGN KEY ([Category]) REFERENCES [dbo].[ECategory] ([ECategoryId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
