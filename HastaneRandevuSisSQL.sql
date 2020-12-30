--
-- PostgreSQL database dump
--

-- Dumped from database version 13.1
-- Dumped by pg_dump version 13.1

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: HastaneTakipDB; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE "HastaneTakipDB" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Turkish_Turkey.1254';


ALTER DATABASE "HastaneTakipDB" OWNER TO postgres;

\connect "HastaneTakipDB"

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: RandevuKaydedildiTR2(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public."RandevuKaydedildiTR2"() RETURNS trigger
    LANGUAGE plpgsql
    AS $$

DECLARE 
    cnt INT;
BEGIN 

    cnt :=(SELECT MAX("Id") FROM  "public"."DoktorRandevuSaat" )+1;
INSERT INTO "public"."DoktorRandevuSaat" ("Id","DoktorId","Saat") VALUES (cnt,NEW."DoktorId",NEW."Saat");

RETURN NEW;

END;

$$;


ALTER FUNCTION public."RandevuKaydedildiTR2"() OWNER TO postgres;

--
-- Name: RandevuSilindiTR3(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public."RandevuSilindiTR3"() RETURNS trigger
    LANGUAGE plpgsql
    AS $$

DECLARE 
BEGIN 

 DELETE FROM "public"."DoktorRandevuSaat" WHERE "DoktorId" = OLD."DoktorId" AND "Saat" = OLD."Saat";

RETURN OLD;

END;

$$;


ALTER FUNCTION public."RandevuSilindiTR3"() OWNER TO postgres;

--
-- Name: UserDegisikligiTR1(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public."UserDegisikligiTR1"() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    IF NEW."SehirId" <> OLD."SehirId" THEN
        DELETE FROM "public"."Randevu" WHERE "UserId" = NEW."Id";
    END IF;

    RETURN NEW;
END;
$$;


ALTER FUNCTION public."UserDegisikligiTR1"() OWNER TO postgres;

--
-- Name: UserDegisikligiTalepTR4(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public."UserDegisikligiTalepTR4"() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    IF NEW."SehirId" <> OLD."SehirId" THEN
        DELETE FROM "public"."Talepler";
    END IF;

    RETURN NEW;
END;
$$;


ALTER FUNCTION public."UserDegisikligiTalepTR4"() OWNER TO postgres;

--
-- Name: cocukrandevuolustur(integer, character varying, integer, integer, integer, character varying, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.cocukrandevuolustur(id integer, tarih character varying, doktorid integer, userid integer, saglikkurumuid integer, saat character varying, cocukid integer) RETURNS void
    LANGUAGE plpgsql
    AS $$ -- Fonksiyon govdesinin (tanımının) başlangıcı
BEGIN


  INSERT INTO "public"."Randevu" ("Id","Tarih","DoktorId","UserId","SaglikKurumuId","Saat","CocukId") VALUES (Id,Tarih,DoktorId,UserId,SaglikKurumuId,Saat,CocukId);

END;
$$;


ALTER FUNCTION public.cocukrandevuolustur(id integer, tarih character varying, doktorid integer, userid integer, saglikkurumuid integer, saat character varying, cocukid integer) OWNER TO postgres;

--
-- Name: deleterandevu(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.deleterandevu(id integer) RETURNS void
    LANGUAGE plpgsql
    AS $$ -- Fonksiyon govdesinin (tanımının) başlangıcı
BEGIN

    DELETE FROM "public"."Randevu" WHERE "Id" = Id;
   
END;
$$;


ALTER FUNCTION public.deleterandevu(id integer) OWNER TO postgres;

--
-- Name: randevuolustur(integer, character varying, integer, integer, integer, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.randevuolustur(id integer, tarih character varying, doktorid integer, userid integer, saglikkurumuid integer, saat character varying) RETURNS void
    LANGUAGE plpgsql
    AS $$ -- Fonksiyon govdesinin (tanımının) başlangıcı
BEGIN


  INSERT INTO "public"."Randevu" ("Id","Tarih","DoktorId","UserId","SaglikKurumuId","Saat") VALUES (Id,Tarih,DoktorId,UserId,SaglikKurumuId,Saat);

END;
$$;


ALTER FUNCTION public.randevuolustur(id integer, tarih character varying, doktorid integer, userid integer, saglikkurumuid integer, saat character varying) OWNER TO postgres;

--
-- Name: userupdate(integer, character varying, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.userupdate(id integer, pass character varying, sehirid integer) RETURNS void
    LANGUAGE plpgsql
    AS $$ -- Fonksiyon govdesinin (tanımının) başlangıcı
BEGIN
    
    UPDATE "public"."User" SET "Password" = Pass,"SehirId"=SehirId WHERE "Id"=Id;
END;
$$;


ALTER FUNCTION public.userupdate(id integer, pass character varying, sehirid integer) OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: ASM; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."ASM" (
    "SkId" integer NOT NULL
);


ALTER TABLE public."ASM" OWNER TO postgres;

--
-- Name: Bolum; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Bolum" (
    "Id" integer NOT NULL,
    "SkId" integer NOT NULL,
    "Name" character varying(255) NOT NULL
);


ALTER TABLE public."Bolum" OWNER TO postgres;

--
-- Name: Bolum_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Bolum_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Bolum_Id_seq" OWNER TO postgres;

--
-- Name: Bolum_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Bolum_Id_seq" OWNED BY public."Bolum"."Id";


--
-- Name: Cocuk; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Cocuk" (
    "Id" integer NOT NULL,
    "EbeveynId" integer NOT NULL,
    "AdSoyad" character varying(255) NOT NULL
);


ALTER TABLE public."Cocuk" OWNER TO postgres;

--
-- Name: Cocuk_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Cocuk_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Cocuk_Id_seq" OWNER TO postgres;

--
-- Name: Cocuk_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Cocuk_Id_seq" OWNED BY public."Cocuk"."Id";


--
-- Name: Doktor; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Doktor" (
    "Id" integer NOT NULL,
    "Name" character varying(255) NOT NULL,
    "BolumId" integer,
    "PuanId" integer NOT NULL,
    "MahId" integer,
    "BosTarihBas" character varying(50) NOT NULL,
    "BosTarihSon" character varying(50) NOT NULL,
    "BosSaatBas" character varying(50) NOT NULL,
    "BosSaatSon" character varying(50) NOT NULL
);


ALTER TABLE public."Doktor" OWNER TO postgres;

--
-- Name: DoktorRandevuSaat; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."DoktorRandevuSaat" (
    "Id" integer NOT NULL,
    "DoktorId" integer NOT NULL,
    "Saat" character varying(20) NOT NULL
);


ALTER TABLE public."DoktorRandevuSaat" OWNER TO postgres;

--
-- Name: DoktorRandevuSaat_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."DoktorRandevuSaat_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."DoktorRandevuSaat_Id_seq" OWNER TO postgres;

--
-- Name: DoktorRandevuSaat_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."DoktorRandevuSaat_Id_seq" OWNED BY public."DoktorRandevuSaat"."Id";


--
-- Name: Doktor_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Doktor_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Doktor_Id_seq" OWNER TO postgres;

--
-- Name: Doktor_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Doktor_Id_seq" OWNED BY public."Doktor"."Id";


--
-- Name: Duyuru; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Duyuru" (
    "Id" integer NOT NULL,
    "Text" character varying(150) NOT NULL,
    "KaynakId" integer
);


ALTER TABLE public."Duyuru" OWNER TO postgres;

--
-- Name: Duyuru_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Duyuru_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Duyuru_Id_seq" OWNER TO postgres;

--
-- Name: Duyuru_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Duyuru_Id_seq" OWNED BY public."Duyuru"."Id";


--
-- Name: Hastane; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Hastane" (
    "SkId" integer NOT NULL
);


ALTER TABLE public."Hastane" OWNER TO postgres;

--
-- Name: Kaynak; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Kaynak" (
    "Id" integer NOT NULL,
    "Name" character varying(50) NOT NULL
);


ALTER TABLE public."Kaynak" OWNER TO postgres;

--
-- Name: Kaynak_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Kaynak_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Kaynak_Id_seq" OWNER TO postgres;

--
-- Name: Kaynak_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Kaynak_Id_seq" OWNED BY public."Kaynak"."Id";


--
-- Name: Mah; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Mah" (
    "Id" integer NOT NULL,
    "SkId" integer NOT NULL,
    "Name" character varying(255) NOT NULL
);


ALTER TABLE public."Mah" OWNER TO postgres;

--
-- Name: Mah_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Mah_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Mah_Id_seq" OWNER TO postgres;

--
-- Name: Mah_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Mah_Id_seq" OWNED BY public."Mah"."Id";


--
-- Name: OzelDurum; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."OzelDurum" (
    "Id" integer NOT NULL,
    "Name" character varying(50) NOT NULL
);


ALTER TABLE public."OzelDurum" OWNER TO postgres;

--
-- Name: OzelDurum_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."OzelDurum_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."OzelDurum_Id_seq" OWNER TO postgres;

--
-- Name: OzelDurum_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."OzelDurum_Id_seq" OWNED BY public."OzelDurum"."Id";


--
-- Name: Puan; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Puan" (
    "Id" integer NOT NULL,
    "Value" double precision NOT NULL
);


ALTER TABLE public."Puan" OWNER TO postgres;

--
-- Name: Puan_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Puan_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Puan_Id_seq" OWNER TO postgres;

--
-- Name: Puan_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Puan_Id_seq" OWNED BY public."Puan"."Id";


--
-- Name: Randevu; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Randevu" (
    "Id" integer NOT NULL,
    "Tarih" character varying(50) NOT NULL,
    "DoktorId" integer,
    "UserId" integer NOT NULL,
    "SaglikKurumuId" integer,
    "Saat" character varying(10) NOT NULL,
    "CocukId" integer
);


ALTER TABLE public."Randevu" OWNER TO postgres;

--
-- Name: Randevu_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Randevu_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Randevu_Id_seq" OWNER TO postgres;

--
-- Name: Randevu_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Randevu_Id_seq" OWNED BY public."Randevu"."Id";


--
-- Name: SaglikKurumu; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."SaglikKurumu" (
    "Id" integer NOT NULL,
    "Name" character varying(255) NOT NULL,
    "SehirId" integer NOT NULL
);


ALTER TABLE public."SaglikKurumu" OWNER TO postgres;

--
-- Name: SaglikKurumu_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."SaglikKurumu_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."SaglikKurumu_Id_seq" OWNER TO postgres;

--
-- Name: SaglikKurumu_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."SaglikKurumu_Id_seq" OWNED BY public."SaglikKurumu"."Id";


--
-- Name: Sehir; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Sehir" (
    "Id" integer NOT NULL,
    "Name" character varying(50) NOT NULL
);


ALTER TABLE public."Sehir" OWNER TO postgres;

--
-- Name: Sehir_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Sehir_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Sehir_Id_seq" OWNER TO postgres;

--
-- Name: Sehir_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Sehir_Id_seq" OWNED BY public."Sehir"."Id";


--
-- Name: Talepler; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Talepler" (
    "Id" integer NOT NULL,
    "Text" character varying(150) NOT NULL,
    "OzelDurumId" integer
);


ALTER TABLE public."Talepler" OWNER TO postgres;

--
-- Name: Talepler_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Talepler_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Talepler_Id_seq" OWNER TO postgres;

--
-- Name: Talepler_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Talepler_Id_seq" OWNED BY public."Talepler"."Id";


--
-- Name: User; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."User" (
    "Id" integer NOT NULL,
    "AdSoyad" character varying(255) NOT NULL,
    "Tckn" character varying(13) NOT NULL,
    "Password" character varying(20) NOT NULL,
    "SehirId" integer NOT NULL
);


ALTER TABLE public."User" OWNER TO postgres;

--
-- Name: User_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."User_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."User_Id_seq" OWNER TO postgres;

--
-- Name: User_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."User_Id_seq" OWNED BY public."User"."Id";


--
-- Name: Bolum Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Bolum" ALTER COLUMN "Id" SET DEFAULT nextval('public."Bolum_Id_seq"'::regclass);


--
-- Name: Cocuk Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Cocuk" ALTER COLUMN "Id" SET DEFAULT nextval('public."Cocuk_Id_seq"'::regclass);


--
-- Name: Doktor Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Doktor" ALTER COLUMN "Id" SET DEFAULT nextval('public."Doktor_Id_seq"'::regclass);


--
-- Name: DoktorRandevuSaat Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."DoktorRandevuSaat" ALTER COLUMN "Id" SET DEFAULT nextval('public."DoktorRandevuSaat_Id_seq"'::regclass);


--
-- Name: Duyuru Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Duyuru" ALTER COLUMN "Id" SET DEFAULT nextval('public."Duyuru_Id_seq"'::regclass);


--
-- Name: Kaynak Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Kaynak" ALTER COLUMN "Id" SET DEFAULT nextval('public."Kaynak_Id_seq"'::regclass);


--
-- Name: Mah Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Mah" ALTER COLUMN "Id" SET DEFAULT nextval('public."Mah_Id_seq"'::regclass);


--
-- Name: OzelDurum Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."OzelDurum" ALTER COLUMN "Id" SET DEFAULT nextval('public."OzelDurum_Id_seq"'::regclass);


--
-- Name: Puan Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Puan" ALTER COLUMN "Id" SET DEFAULT nextval('public."Puan_Id_seq"'::regclass);


--
-- Name: Randevu Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Randevu" ALTER COLUMN "Id" SET DEFAULT nextval('public."Randevu_Id_seq"'::regclass);


--
-- Name: SaglikKurumu Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."SaglikKurumu" ALTER COLUMN "Id" SET DEFAULT nextval('public."SaglikKurumu_Id_seq"'::regclass);


--
-- Name: Sehir Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Sehir" ALTER COLUMN "Id" SET DEFAULT nextval('public."Sehir_Id_seq"'::regclass);


--
-- Name: Talepler Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Talepler" ALTER COLUMN "Id" SET DEFAULT nextval('public."Talepler_Id_seq"'::regclass);


--
-- Name: User Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."User" ALTER COLUMN "Id" SET DEFAULT nextval('public."User_Id_seq"'::regclass);


--
-- Data for Name: ASM; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."ASM" VALUES (4);
INSERT INTO public."ASM" VALUES (5);
INSERT INTO public."ASM" VALUES (6);


--
-- Data for Name: Bolum; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Bolum" VALUES (1, 1, 'Kardiyoloji');
INSERT INTO public."Bolum" VALUES (2, 1, 'Nöroloji');
INSERT INTO public."Bolum" VALUES (3, 2, 'Kardiyoloji');
INSERT INTO public."Bolum" VALUES (4, 2, 'Nöroloji');
INSERT INTO public."Bolum" VALUES (5, 3, 'Kardiyoloji');
INSERT INTO public."Bolum" VALUES (6, 3, 'Nöroloji');


--
-- Data for Name: Cocuk; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Cocuk" VALUES (1, 2, 'baramsu Nur');
INSERT INTO public."Cocuk" VALUES (2, 3, 'aynur');
INSERT INTO public."Cocuk" VALUES (3, 3, 'cemile');
INSERT INTO public."Cocuk" VALUES (4, 3, 'nur');
INSERT INTO public."Cocuk" VALUES (5, 5, 'reyhan');


--
-- Data for Name: Doktor; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Doktor" VALUES (20, 'Dr.Ahmet', 1, 1, NULL, '01-12-2020', '05-12-2020', '08:00', '17:00');
INSERT INTO public."Doktor" VALUES (21, 'Dr.Hilal', 1, 1, NULL, '01-12-2020', '07-12-2020', '12:00', '17:00');
INSERT INTO public."Doktor" VALUES (22, 'Dr.Günay', 2, 3, NULL, '01-12-2020', '07-12-2020', '12:00', '17:00');
INSERT INTO public."Doktor" VALUES (23, 'Dr.Mehmet', 2, 4, NULL, '01-12-2020', '07-12-2020', '08:00', '17:00');
INSERT INTO public."Doktor" VALUES (24, 'Dr.Ayşe', 3, 3, NULL, '01-12-2020', '07-12-2020', '12:00', '17:00');
INSERT INTO public."Doktor" VALUES (25, 'Dr.Mert', 3, 4, NULL, '01-12-2020', '07-12-2020', '08:00', '17:00');
INSERT INTO public."Doktor" VALUES (26, 'Dr.Sedef', 4, 2, NULL, '01-12-2020', '07-12-2020', '12:00', '17:00');
INSERT INTO public."Doktor" VALUES (27, 'Dr.Güneş', 4, 4, NULL, '01-12-2020', '07-12-2020', '08:00', '17:00');
INSERT INTO public."Doktor" VALUES (28, 'Dr.Erhan', 5, 3, NULL, '01-12-2020', '07-12-2020', '12:00', '17:00');
INSERT INTO public."Doktor" VALUES (29, 'Dr.Kenan', 5, 4, NULL, '01-12-2020', '07-12-2020', '08:00', '17:00');
INSERT INTO public."Doktor" VALUES (30, 'Dr.Feriha', 6, 3, NULL, '01-12-2020', '07-12-2020', '12:00', '17:00');
INSERT INTO public."Doktor" VALUES (31, 'Dr.Aslı', 6, 4, NULL, '01-12-2020', '07-12-2020', '08:00', '17:00');
INSERT INTO public."Doktor" VALUES (32, 'Dr.Aynur', NULL, 4, 8, '01-12-2020', '07-12-2020', '08:00', '17:00');
INSERT INTO public."Doktor" VALUES (33, 'Dr.Süleyman', NULL, 3, 9, '01-12-2020', '07-12-2020', '08:00', '17:00');
INSERT INTO public."Doktor" VALUES (34, 'Dr.Nuri', NULL, 5, 10, '01-12-2020', '07-12-2020', '08:00', '17:00');
INSERT INTO public."Doktor" VALUES (35, 'Dr.Asya', NULL, 3, 12, '01-12-2020', '07-12-2020', '08:00', '17:00');
INSERT INTO public."Doktor" VALUES (36, 'Dr.Sema', NULL, 3, 13, '01-12-2020', '07-12-2020', '08:00', '17:00');


--
-- Data for Name: DoktorRandevuSaat; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."DoktorRandevuSaat" VALUES (1, 30, '15:00');
INSERT INTO public."DoktorRandevuSaat" VALUES (2, 30, '13:00');
INSERT INTO public."DoktorRandevuSaat" VALUES (3, 20, '15:00');


--
-- Data for Name: Duyuru; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Duyuru" VALUES (14, '“Ülkemizde de ekim ayının ikinci yarısından itibaren hızlı bir vaka artışı baş gösterdi.', 1);


--
-- Data for Name: Hastane; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Hastane" VALUES (1);
INSERT INTO public."Hastane" VALUES (2);
INSERT INTO public."Hastane" VALUES (3);


--
-- Data for Name: Kaynak; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Kaynak" VALUES (1, 'Saglik Bakanligi');


--
-- Data for Name: Mah; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Mah" VALUES (8, 4, 'Yesil Mah');
INSERT INTO public."Mah" VALUES (9, 4, 'Yeni Mah');
INSERT INTO public."Mah" VALUES (10, 5, 'Atatürk Mah');
INSERT INTO public."Mah" VALUES (11, 5, 'Sarı Mah');
INSERT INTO public."Mah" VALUES (12, 6, 'İstiklal Mah');
INSERT INTO public."Mah" VALUES (13, 6, 'Cumhuriyet Mah');


--
-- Data for Name: OzelDurum; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."OzelDurum" VALUES (1, '65+');
INSERT INTO public."OzelDurum" VALUES (2, 'Engelli');
INSERT INTO public."OzelDurum" VALUES (3, 'Hamile');
INSERT INTO public."OzelDurum" VALUES (4, 'Covid19');


--
-- Data for Name: Puan; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Puan" VALUES (1, 1);
INSERT INTO public."Puan" VALUES (2, 2);
INSERT INTO public."Puan" VALUES (3, 3);
INSERT INTO public."Puan" VALUES (4, 4);
INSERT INTO public."Puan" VALUES (5, 5);


--
-- Data for Name: Randevu; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Randevu" VALUES (1, '05-12-2020', 20, 2, 1, '15:00', NULL);


--
-- Data for Name: SaglikKurumu; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."SaglikKurumu" VALUES (1, 'Kastamonu Devlet Hastanesi', 37);
INSERT INTO public."SaglikKurumu" VALUES (2, 'Sakarya Egitim Arastirma Hastanesi', 54);
INSERT INTO public."SaglikKurumu" VALUES (3, 'İstanbul Devlet Hastanesi', 34);
INSERT INTO public."SaglikKurumu" VALUES (4, 'Kastamonu Aile Sagligi Merkezi', 37);
INSERT INTO public."SaglikKurumu" VALUES (5, 'Sakarya Aile Sagligi Merkezi', 54);
INSERT INTO public."SaglikKurumu" VALUES (6, 'İstanbul Aile Sagligi Merkezi', 34);


--
-- Data for Name: Sehir; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Sehir" VALUES (37, 'Kastamonu');
INSERT INTO public."Sehir" VALUES (34, 'İstanbul');
INSERT INTO public."Sehir" VALUES (54, 'Sakarya');


--
-- Data for Name: Talepler; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: User; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."User" VALUES (1, 'Aysima ', '11111111111', '111111', 37);
INSERT INTO public."User" VALUES (4, 'aysenur', '55555555555', '123456789', 34);
INSERT INTO public."User" VALUES (5, 'ayse sena', '77777777777', '123456789', 34);
INSERT INTO public."User" VALUES (2, 'Mert G', '12121212121', '123456', 37);
INSERT INTO public."User" VALUES (3, 'Aysima Savaş', '44444444444', '123456789', 34);


--
-- Name: Bolum_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Bolum_Id_seq"', 1, false);


--
-- Name: Cocuk_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Cocuk_Id_seq"', 1, false);


--
-- Name: DoktorRandevuSaat_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."DoktorRandevuSaat_Id_seq"', 1, false);


--
-- Name: Doktor_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Doktor_Id_seq"', 1, false);


--
-- Name: Duyuru_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Duyuru_Id_seq"', 1, false);


--
-- Name: Kaynak_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Kaynak_Id_seq"', 1, false);


--
-- Name: Mah_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Mah_Id_seq"', 1, false);


--
-- Name: OzelDurum_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."OzelDurum_Id_seq"', 1, false);


--
-- Name: Puan_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Puan_Id_seq"', 1, false);


--
-- Name: Randevu_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Randevu_Id_seq"', 1, false);


--
-- Name: SaglikKurumu_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."SaglikKurumu_Id_seq"', 1, false);


--
-- Name: Sehir_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Sehir_Id_seq"', 1, false);


--
-- Name: Talepler_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Talepler_Id_seq"', 1, false);


--
-- Name: User_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."User_Id_seq"', 1, false);


--
-- Name: ASM ASMPK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."ASM"
    ADD CONSTRAINT "ASMPK" PRIMARY KEY ("SkId");


--
-- Name: Bolum Bolum_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Bolum"
    ADD CONSTRAINT "Bolum_pkey" PRIMARY KEY ("Id");


--
-- Name: Cocuk Cocuk_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Cocuk"
    ADD CONSTRAINT "Cocuk_pkey" PRIMARY KEY ("Id");


--
-- Name: DoktorRandevuSaat DoktorRandevuSaat_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."DoktorRandevuSaat"
    ADD CONSTRAINT "DoktorRandevuSaat_pkey" PRIMARY KEY ("Id");


--
-- Name: Doktor Doktor_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Doktor"
    ADD CONSTRAINT "Doktor_pkey" PRIMARY KEY ("Id");


--
-- Name: Duyuru Duyuru_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Duyuru"
    ADD CONSTRAINT "Duyuru_pkey" PRIMARY KEY ("Id");


--
-- Name: Hastane HastanePK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Hastane"
    ADD CONSTRAINT "HastanePK" PRIMARY KEY ("SkId");


--
-- Name: Kaynak Kaynak_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Kaynak"
    ADD CONSTRAINT "Kaynak_pkey" PRIMARY KEY ("Id");


--
-- Name: Mah Mah_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Mah"
    ADD CONSTRAINT "Mah_pkey" PRIMARY KEY ("Id");


--
-- Name: OzelDurum OzelDurum_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."OzelDurum"
    ADD CONSTRAINT "OzelDurum_pkey" PRIMARY KEY ("Id");


--
-- Name: Puan Puan_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Puan"
    ADD CONSTRAINT "Puan_pkey" PRIMARY KEY ("Id");


--
-- Name: Randevu Randevu_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Randevu"
    ADD CONSTRAINT "Randevu_pkey" PRIMARY KEY ("Id");


--
-- Name: SaglikKurumu SaglikKurumu_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."SaglikKurumu"
    ADD CONSTRAINT "SaglikKurumu_pkey" PRIMARY KEY ("Id");


--
-- Name: Sehir Sehir_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Sehir"
    ADD CONSTRAINT "Sehir_pkey" PRIMARY KEY ("Id");


--
-- Name: Talepler Talepler_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Talepler"
    ADD CONSTRAINT "Talepler_pkey" PRIMARY KEY ("Id");


--
-- Name: User User_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."User"
    ADD CONSTRAINT "User_pkey" PRIMARY KEY ("Id");


--
-- Name: Randevu RandevuKaldirildi; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER "RandevuKaldirildi" BEFORE DELETE ON public."Randevu" FOR EACH ROW EXECUTE FUNCTION public."RandevuSilindiTR3"();


--
-- Name: Randevu RandevuSaatEkle; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER "RandevuSaatEkle" BEFORE INSERT ON public."Randevu" FOR EACH ROW EXECUTE FUNCTION public."RandevuKaydedildiTR2"();


--
-- Name: User userBilgileriDegistiginde; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER "userBilgileriDegistiginde" BEFORE UPDATE ON public."User" FOR EACH ROW EXECUTE FUNCTION public."UserDegisikligiTR1"();


--
-- Name: User userBilgileriDegistigindeTalep; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER "userBilgileriDegistigindeTalep" BEFORE UPDATE ON public."User" FOR EACH ROW EXECUTE FUNCTION public."UserDegisikligiTalepTR4"();


--
-- Name: ASM ASMKurumu; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."ASM"
    ADD CONSTRAINT "ASMKurumu" FOREIGN KEY ("SkId") REFERENCES public."SaglikKurumu"("Id") ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Bolum Bolum_SkId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Bolum"
    ADD CONSTRAINT "Bolum_SkId_fkey" FOREIGN KEY ("SkId") REFERENCES public."Hastane"("SkId");


--
-- Name: Cocuk Cocuk_EbeveynId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Cocuk"
    ADD CONSTRAINT "Cocuk_EbeveynId_fkey" FOREIGN KEY ("EbeveynId") REFERENCES public."User"("Id");


--
-- Name: DoktorRandevuSaat DoktorRandevuSaat_DoktorId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."DoktorRandevuSaat"
    ADD CONSTRAINT "DoktorRandevuSaat_DoktorId_fkey" FOREIGN KEY ("DoktorId") REFERENCES public."Doktor"("Id");


--
-- Name: Doktor Doktor_BolumId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Doktor"
    ADD CONSTRAINT "Doktor_BolumId_fkey" FOREIGN KEY ("BolumId") REFERENCES public."Bolum"("Id");


--
-- Name: Doktor Doktor_MahId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Doktor"
    ADD CONSTRAINT "Doktor_MahId_fkey" FOREIGN KEY ("MahId") REFERENCES public."Mah"("Id");


--
-- Name: Doktor Doktor_PuanId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Doktor"
    ADD CONSTRAINT "Doktor_PuanId_fkey" FOREIGN KEY ("PuanId") REFERENCES public."Puan"("Id");


--
-- Name: Duyuru Duyuru_KaynakId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Duyuru"
    ADD CONSTRAINT "Duyuru_KaynakId_fkey" FOREIGN KEY ("KaynakId") REFERENCES public."Kaynak"("Id");


--
-- Name: Hastane HastaneKurumu; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Hastane"
    ADD CONSTRAINT "HastaneKurumu" FOREIGN KEY ("SkId") REFERENCES public."SaglikKurumu"("Id") ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Mah Mah_SkId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Mah"
    ADD CONSTRAINT "Mah_SkId_fkey" FOREIGN KEY ("SkId") REFERENCES public."ASM"("SkId");


--
-- Name: Randevu Randevu_CocukId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Randevu"
    ADD CONSTRAINT "Randevu_CocukId_fkey" FOREIGN KEY ("CocukId") REFERENCES public."Cocuk"("Id");


--
-- Name: Randevu Randevu_DoktorId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Randevu"
    ADD CONSTRAINT "Randevu_DoktorId_fkey" FOREIGN KEY ("DoktorId") REFERENCES public."Doktor"("Id");


--
-- Name: Randevu Randevu_SaglikKurumuId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Randevu"
    ADD CONSTRAINT "Randevu_SaglikKurumuId_fkey" FOREIGN KEY ("SaglikKurumuId") REFERENCES public."SaglikKurumu"("Id");


--
-- Name: Randevu Randevu_UserId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Randevu"
    ADD CONSTRAINT "Randevu_UserId_fkey" FOREIGN KEY ("UserId") REFERENCES public."User"("Id");


--
-- Name: SaglikKurumu SaglikKurumu_SehirId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."SaglikKurumu"
    ADD CONSTRAINT "SaglikKurumu_SehirId_fkey" FOREIGN KEY ("SehirId") REFERENCES public."Sehir"("Id");


--
-- Name: Talepler Talepler_OzelDurumId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Talepler"
    ADD CONSTRAINT "Talepler_OzelDurumId_fkey" FOREIGN KEY ("OzelDurumId") REFERENCES public."OzelDurum"("Id");


--
-- Name: User User_SehirId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."User"
    ADD CONSTRAINT "User_SehirId_fkey" FOREIGN KEY ("SehirId") REFERENCES public."Sehir"("Id");


--
-- PostgreSQL database dump complete
--

