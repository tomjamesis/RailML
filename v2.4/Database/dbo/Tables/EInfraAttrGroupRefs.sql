CREATE TABLE [dbo].[EInfraAttrGroupRefs]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EInfraAttrGroupRefsId]	BIGINT		NOT NULL,
	[InfraAttrGroupRef]	BIGINT		NOT NULL,

	CONSTRAINT [PK_EInfraAttrGroupRefsId] PRIMARY KEY CLUSTERED ([EInfraAttrGroupRefsId] ASC),
	CONSTRAINT [FK_EInfraAttrGroupRefs_TElementWithReference] FOREIGN KEY ([InfraAttrGroupRef]) REFERENCES [dbo].[TElementWithReference] ([TElementWithReferenceId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
