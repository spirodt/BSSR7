
CREATE view [dbo].[KontrolaNaSmetka] 
as
select s.ID SmetkaID, S.Broj as BrojNaSmetka, 
isnull(dbo.IznosOdSmetka(S.ID),0) as VkupenPromet,
isnull(dbo.IznosOdNalozi(S.ID),0) as VkupnoNalozi,
isnull(dbo.IznosOdFiskalna(S.ID),0) as VkupnoFiskalna,
isnull(dbo.IznosOdSmetka(S.ID),0) - isnull(dbo.IznosOdFiskalna(S.ID),0) as VkupnoNeFiskalenPromet,
 S.DatumPocetok, S.DatumKraj, u.FullName,s.tblUserID, S.Zabeleska, s.Zatvorena, s.Izmeneta, dbo.DaliImaFiskalna(s.ID) as Fiskalna
 from tblSmetka s
left outer join tblUsers u on u.ID = s.tblUserID
