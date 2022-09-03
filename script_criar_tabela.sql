 CREATE TABLE [dbo].[t_produto](
	[id_produto] [int] IDENTITY(1,1) NOT NULL,
	[nm_produto] [varchar](300) NULL,
	[nr_produto] [numeric](20, 0) NULL,
	[dt_cadastro] [smalldatetime] NULL,
 CONSTRAINT [pk_t_produto] PRIMARY KEY CLUSTERED 
(
	[id_produto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


