--
-- PostgreSQL database dump
--

-- Dumped from database version 16.4
-- Dumped by pg_dump version 16.4

-- Started on 2024-08-21 12:15:18

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

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 216 (class 1259 OID 16399)
-- Name: tab_hotels; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tab_hotels (
    id integer NOT NULL,
    name character varying(300),
    price numeric(10,2),
    location character varying(500),
    available_rooms integer,
    availability boolean,
    img_path character varying(500)
);


ALTER TABLE public.tab_hotels OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 16398)
-- Name: tab_hotels_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tab_hotels_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tab_hotels_id_seq OWNER TO postgres;

--
-- TOC entry 4841 (class 0 OID 0)
-- Dependencies: 215
-- Name: tab_hotels_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tab_hotels_id_seq OWNED BY public.tab_hotels.id;


--
-- TOC entry 4688 (class 2604 OID 16402)
-- Name: tab_hotels id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tab_hotels ALTER COLUMN id SET DEFAULT nextval('public.tab_hotels_id_seq'::regclass);


--
-- TOC entry 4835 (class 0 OID 16399)
-- Dependencies: 216
-- Data for Name: tab_hotels; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tab_hotels (id, name, price, location, available_rooms, availability, img_path) FROM stdin;
\.


--
-- TOC entry 4842 (class 0 OID 0)
-- Dependencies: 215
-- Name: tab_hotels_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tab_hotels_id_seq', 1, false);


--
-- TOC entry 4690 (class 2606 OID 16406)
-- Name: tab_hotels tab_hotels_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tab_hotels
    ADD CONSTRAINT tab_hotels_pkey PRIMARY KEY (id);


-- Completed on 2024-08-21 12:15:18

--
-- PostgreSQL database dump complete
--

