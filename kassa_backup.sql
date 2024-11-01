PGDMP     5    3        	        {            kassa    15.3    15.3 S    D           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            E           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            F           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            G           1262    16585    kassa    DATABASE     y   CREATE DATABASE kassa WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE kassa;
                postgres    false            H           0    0    DATABASE kassa    ACL     +   GRANT ALL ON DATABASE kassa TO all_rights;
                   postgres    false    3399            �            1255    16655    count_chek()    FUNCTION     �   CREATE FUNCTION public.count_chek() RETURNS integer
    LANGUAGE plpgsql
    AS $$
DECLARE
    chek_counter INT;
BEGIN
    SELECT COUNT(*) INTO chek_counter
    FROM cheki;
    
    RETURN chek_counter;
END;
$$;
 #   DROP FUNCTION public.count_chek();
       public          postgres    false            �            1255    16648    del()    FUNCTION     �   CREATE FUNCTION public.del() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
		 UPDATE products
		 SET quantity_stock = quantity_stock + OLD.quantity WHERE id = OLD.product_id;
    RETURN NEW;
END;
$$;
    DROP FUNCTION public.del();
       public          postgres    false            �            1255    16637    delete_cheki(integer) 	   PROCEDURE     �   CREATE PROCEDURE public.delete_cheki(IN _id integer)
    LANGUAGE plpgsql
    AS $$
    BEGIN
		DELETE FROM cheki WHERE id = _id;
    END;
$$;
 4   DROP PROCEDURE public.delete_cheki(IN _id integer);
       public          postgres    false            �            1255    16638    delete_kassiri(integer) 	   PROCEDURE     �   CREATE PROCEDURE public.delete_kassiri(IN _id integer)
    LANGUAGE plpgsql
    AS $$
    BEGIN
		DELETE FROM kassiri WHERE id = _id;
    END;
$$;
 6   DROP PROCEDURE public.delete_kassiri(IN _id integer);
       public          postgres    false            �            1255    16636    delete_kuplen_products(integer) 	   PROCEDURE     �   CREATE PROCEDURE public.delete_kuplen_products(IN _id integer)
    LANGUAGE plpgsql
    AS $$
    BEGIN
		DELETE FROM kuplen_products WHERE id = _id;
    END;
$$;
 >   DROP PROCEDURE public.delete_kuplen_products(IN _id integer);
       public          postgres    false            �            1255    16670    delete_my_view(integer) 	   PROCEDURE     �   CREATE PROCEDURE public.delete_my_view(IN _id integer)
    LANGUAGE plpgsql
    AS $$
    BEGIN
		DELETE FROM my_view WHERE id = _id;
    END;
$$;
 6   DROP PROCEDURE public.delete_my_view(IN _id integer);
       public          postgres    false            �            1255    16639    delete_products(integer) 	   PROCEDURE     �   CREATE PROCEDURE public.delete_products(IN _id integer)
    LANGUAGE plpgsql
    AS $$
    BEGIN
		DELETE FROM products WHERE id = _id;
    END;
$$;
 7   DROP PROCEDURE public.delete_products(IN _id integer);
       public          postgres    false                        1255    16671    delete_row_view()    FUNCTION     �   CREATE FUNCTION public.delete_row_view() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
	DELETE FROM cheki WHERE id = OLD.id;
    RETURN NULL;
END;
$$;
 (   DROP FUNCTION public.delete_row_view();
       public          postgres    false            �            1255    16644    dob()    FUNCTION     �   CREATE FUNCTION public.dob() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
		 UPDATE products
		 SET quantity_stock = quantity_stock - NEW.quantity WHERE id = NEW.product_id;
    RETURN NEW;
END;
$$;
    DROP FUNCTION public.dob();
       public          postgres    false            �            1255    16634 2   insert_cheki(character varying, character varying) 	   PROCEDURE     R  CREATE PROCEDURE public.insert_cheki(IN _fio_kassira character varying, IN _job character varying)
    LANGUAGE plpgsql
    AS $$
DECLARE
    DECLARE _kas_id INT;
BEGIN
    SELECT id INTO _kas_id FROM kassiri WHERE fio_kassira = _fio_kassira and job = _job;
    BEGIN
        INSERT INTO cheki(kas_id) VALUES (_kas_id);
        IF (_kas_id IS NOT NULL) THEN
            COMMIT;
            RAISE NOTICE 'Транзакция зафиксирована.';
        ELSE
            ROLLBACK;
            RAISE EXCEPTION 'Кассир не существует';
        END IF;
    END;
END;
$$;
 b   DROP PROCEDURE public.insert_cheki(IN _fio_kassira character varying, IN _job character varying);
       public          postgres    false            �            1255    16633 =   insert_kassiri(character varying, integer, character varying) 	   PROCEDURE     �   CREATE PROCEDURE public.insert_kassiri(IN _fio_kassira character varying, IN _age integer, IN _job character varying)
    LANGUAGE sql
    AS $$
    INSERT INTO kassiri(fio_kassira, age, job) VALUES (_fio_kassira, _age, _job);
$$;
 u   DROP PROCEDURE public.insert_kassiri(IN _fio_kassira character varying, IN _age integer, IN _job character varying);
       public          postgres    false            �            1255    16635 2   insert_kuplen_products(character varying, integer) 	   PROCEDURE       CREATE PROCEDURE public.insert_kuplen_products(IN _nazvanie character varying, IN _quantity integer)
    LANGUAGE plpgsql
    AS $$
DECLARE
    DECLARE _product_id INT;
BEGIN
    SELECT id INTO _product_id FROM products WHERE (nazvanie = _nazvanie and quantity_stock>=_quantity);
    BEGIN
        INSERT INTO kuplen_products(product_id, check_id, quantity, price_products) 
		VALUES(_product_id, (SELECT id FROM cheki order by id DESC LIMIT 1), _quantity, _quantity*(SELECT price FROM products WHERE id = _product_id));
        IF (_product_id IS NOT NULL) THEN
            COMMIT;
            RAISE NOTICE 'Транзакция зафиксирована.';
        ELSE
            ROLLBACK;
            RAISE EXCEPTION 'Товар не существует';
        END IF;
    END;
END;
$$;
 d   DROP PROCEDURE public.insert_kuplen_products(IN _nazvanie character varying, IN _quantity integer);
       public          postgres    false            �            1255    16667 4   insert_my_view(character varying, character varying) 	   PROCEDURE     �  CREATE PROCEDURE public.insert_my_view(IN _fio_kassira character varying, IN _job character varying)
    LANGUAGE plpgsql
    AS $$
	DECLARE _kas_id INT;
    BEGIN
		SELECT id INTO _kas_id FROM kassiri WHERE fio_kassira = _fio_kassira and job = _job;
		INSERT INTO my_view(kas_id) VALUES(_kas_id) ;
        IF (_kas_id IS NULL) THEN
            RAISE EXCEPTION 'Кассира не существует';
        END IF;
    END;
$$;
 d   DROP PROCEDURE public.insert_my_view(IN _fio_kassira character varying, IN _job character varying);
       public          postgres    false            �            1255    16632 4   insert_products(character varying, numeric, integer) 	   PROCEDURE     �   CREATE PROCEDURE public.insert_products(IN _nazvanie character varying, IN _price numeric, IN _quantity_stock integer)
    LANGUAGE sql
    AS $$
	INSERT INTO products(nazvanie, price, quantity_stock) VALUES (_nazvanie, _price, _quantity_stock);
$$;
 v   DROP PROCEDURE public.insert_products(IN _nazvanie character varying, IN _price numeric, IN _quantity_stock integer);
       public          postgres    false            �            1255    16668    insert_row_view()    FUNCTION     �   CREATE FUNCTION public.insert_row_view() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
	
	INSERT INTO cheki(kas_id) VALUES (NEW.kas_id);
    RETURN NULL;
END;
$$;
 (   DROP FUNCTION public.insert_row_view();
       public          postgres    false            �            1255    16656    kassi()    FUNCTION       CREATE FUNCTION public.kassi() RETURNS TABLE(id integer, fio_kassira character varying, age integer, job character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN QUERY SELECT k.id, k.fio_kassira, k.age, k.job
                 FROM kassiri k;
END;
$$;
    DROP FUNCTION public.kassi();
       public          postgres    false            �            1255    16654    price_inc()    FUNCTION     �  CREATE FUNCTION public.price_inc() RETURNS TABLE(id integer, nazvanie character varying, price numeric, quantity_stock integer)
    LANGUAGE plpgsql
    AS $$
DECLARE
    cur_r RECORD;
    new_price DECIMAL(15,2);
BEGIN
    FOR cur_r IN SELECT * FROM products LOOP
        new_price := cur_r.price * 1.1;
        UPDATE products SET
            price = new_price
        WHERE products.id = cur_r.id;
    END LOOP;
    RETURN QUERY SELECT * FROM products;
END;
$$;
 "   DROP FUNCTION public.price_inc();
       public          postgres    false            �            1255    16646    upd()    FUNCTION     �   CREATE FUNCTION public.upd() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
		 UPDATE products
		 SET quantity_stock = quantity_stock - (NEW.quantity - OLD.quantity) WHERE id = NEW.product_id;
    RETURN NEW;
END;
$$;
    DROP FUNCTION public.upd();
       public          postgres    false            �            1255    16642 ;   update_cheki(integer, character varying, character varying) 	   PROCEDURE     �  CREATE PROCEDURE public.update_cheki(IN _id integer, IN _fio_kassira character varying, IN _job character varying)
    LANGUAGE plpgsql
    AS $$
	DECLARE _kas_id INT;
    BEGIN
		SELECT id INTO _kas_id FROM kassiri WHERE fio_kassira = _fio_kassira and job = _job;
		UPDATE cheki
		SET kas_id = _kas_id WHERE id = _id;
        IF (_kas_id IS NULL) THEN
            RAISE EXCEPTION 'Кассира не существует';
        END IF;
    END;
$$;
 r   DROP PROCEDURE public.update_cheki(IN _id integer, IN _fio_kassira character varying, IN _job character varying);
       public          postgres    false            �            1255    16641 F   update_kassiri(integer, character varying, integer, character varying) 	   PROCEDURE     �   CREATE PROCEDURE public.update_kassiri(IN _id integer, IN _fio_kassira character varying, IN _age integer, IN _job character varying)
    LANGUAGE sql
    AS $$
	UPDATE kassiri
	SET fio_kassira = _fio_kassira, age = _age, job = _job WHERE id = _id;
$$;
 �   DROP PROCEDURE public.update_kassiri(IN _id integer, IN _fio_kassira character varying, IN _age integer, IN _job character varying);
       public          postgres    false            �            1255    16643 ;   update_kuplen_products(integer, character varying, integer) 	   PROCEDURE     �  CREATE PROCEDURE public.update_kuplen_products(IN _id integer, IN _nazvanie character varying, IN _quantity integer)
    LANGUAGE plpgsql
    AS $$
	DECLARE _product_id INT;
    BEGIN
		SELECT id INTO _product_id FROM products WHERE (nazvanie = _nazvanie and quantity_stock>=_quantity);
		UPDATE kuplen_products
		SET product_id = _product_id, check_id = (SELECT id FROM cheki order by id DESC LIMIT 1), quantity = _quantity, price_products = _quantity *(SELECT price FROM products WHERE id = _product_id) WHERE id = _id;
		IF (_product_id IS NULL) THEN
            RAISE EXCEPTION 'Кассира не существует';
        END IF;
    END;
$$;
 t   DROP PROCEDURE public.update_kuplen_products(IN _id integer, IN _nazvanie character varying, IN _quantity integer);
       public          postgres    false                       1255    16673 =   update_my_view(integer, character varying, character varying) 	   PROCEDURE     �  CREATE PROCEDURE public.update_my_view(IN _id integer, IN _fio_kassira character varying, IN _job character varying)
    LANGUAGE plpgsql
    AS $$
	DECLARE _kas_id INT;
    BEGIN
		SELECT id INTO _kas_id FROM kassiri WHERE fio_kassira = _fio_kassira and job = _job;
		UPDATE my_view
		SET kas_id = _kas_id WHERE id = _id;
        IF (_kas_id IS NULL) THEN
            RAISE EXCEPTION 'Кассира не существует';
        END IF;
    END;
$$;
 t   DROP PROCEDURE public.update_my_view(IN _id integer, IN _fio_kassira character varying, IN _job character varying);
       public          postgres    false            �            1255    16640 =   update_products(integer, character varying, numeric, integer) 	   PROCEDURE       CREATE PROCEDURE public.update_products(IN _id integer, IN _nazvanie character varying, IN _price numeric, IN _quantity_stock integer)
    LANGUAGE sql
    AS $$
	UPDATE products
	SET nazvanie = _nazvanie, price = _price, quantity_stock = _quantity_stock WHERE id = _id;
$$;
 �   DROP PROCEDURE public.update_products(IN _id integer, IN _nazvanie character varying, IN _price numeric, IN _quantity_stock integer);
       public          postgres    false                       1255    16674    update_row_view()    FUNCTION     �   CREATE FUNCTION public.update_row_view() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
	UPDATE cheki
		SET kas_id = NEW.kas_id WHERE id = OLD.id;
    RETURN NULL;
END;
$$;
 (   DROP FUNCTION public.update_row_view();
       public          postgres    false            �            1259    16595    cheki    TABLE     �   CREATE TABLE public.cheki (
    id integer NOT NULL,
    kas_id integer,
    number_chek integer NOT NULL,
    date_create timestamp(0) without time zone DEFAULT now()
);
    DROP TABLE public.cheki;
       public         heap    postgres    false            I           0    0    TABLE cheki    ACL     `   GRANT SELECT ON TABLE public.cheki TO read_only;
GRANT ALL ON TABLE public.cheki TO all_rights;
          public          postgres    false    218            �            1259    16593    cheki_id_seq    SEQUENCE     �   CREATE SEQUENCE public.cheki_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.cheki_id_seq;
       public          postgres    false    218            J           0    0    cheki_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.cheki_id_seq OWNED BY public.cheki.id;
          public          postgres    false    216            K           0    0    SEQUENCE cheki_id_seq    ACL     9   GRANT ALL ON SEQUENCE public.cheki_id_seq TO all_rights;
          public          postgres    false    216            �            1259    16594    cheki_number_chek_seq    SEQUENCE     �   CREATE SEQUENCE public.cheki_number_chek_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public.cheki_number_chek_seq;
       public          postgres    false    218            L           0    0    cheki_number_chek_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public.cheki_number_chek_seq OWNED BY public.cheki.number_chek;
          public          postgres    false    217            M           0    0    SEQUENCE cheki_number_chek_seq    ACL     B   GRANT ALL ON SEQUENCE public.cheki_number_chek_seq TO all_rights;
          public          postgres    false    217            �            1259    16587    kassiri    TABLE     �   CREATE TABLE public.kassiri (
    id integer NOT NULL,
    fio_kassira character varying(50) NOT NULL,
    age integer NOT NULL,
    job character varying(50) NOT NULL
);
    DROP TABLE public.kassiri;
       public         heap    postgres    false            N           0    0    TABLE kassiri    ACL     d   GRANT SELECT ON TABLE public.kassiri TO read_only;
GRANT ALL ON TABLE public.kassiri TO all_rights;
          public          postgres    false    215            �            1259    16586    kassiri_id_seq    SEQUENCE     �   CREATE SEQUENCE public.kassiri_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE public.kassiri_id_seq;
       public          postgres    false    215            O           0    0    kassiri_id_seq    SEQUENCE OWNED BY     A   ALTER SEQUENCE public.kassiri_id_seq OWNED BY public.kassiri.id;
          public          postgres    false    214            P           0    0    SEQUENCE kassiri_id_seq    ACL     ;   GRANT ALL ON SEQUENCE public.kassiri_id_seq TO all_rights;
          public          postgres    false    214            �            1259    16616    kuplen_products    TABLE     �   CREATE TABLE public.kuplen_products (
    id integer NOT NULL,
    check_id integer,
    product_id integer,
    quantity integer NOT NULL,
    price_products numeric(15,2) NOT NULL
);
 #   DROP TABLE public.kuplen_products;
       public         heap    postgres    false            Q           0    0    TABLE kuplen_products    ACL     t   GRANT SELECT ON TABLE public.kuplen_products TO read_only;
GRANT ALL ON TABLE public.kuplen_products TO all_rights;
          public          postgres    false    222            �            1259    16615    kuplen_products_id_seq    SEQUENCE     �   CREATE SEQUENCE public.kuplen_products_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.kuplen_products_id_seq;
       public          postgres    false    222            R           0    0    kuplen_products_id_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.kuplen_products_id_seq OWNED BY public.kuplen_products.id;
          public          postgres    false    221            S           0    0    SEQUENCE kuplen_products_id_seq    ACL     C   GRANT ALL ON SEQUENCE public.kuplen_products_id_seq TO all_rights;
          public          postgres    false    221            �            1259    16663    my_view    VIEW     �   CREATE VIEW public.my_view AS
 SELECT ch.number_chek,
    k.fio_kassira,
    k.job,
    ch.id,
    ch.kas_id,
    ch.date_create
   FROM (public.cheki ch
     JOIN public.kassiri k ON ((ch.kas_id = k.id)))
  ORDER BY ch.number_chek;
    DROP VIEW public.my_view;
       public          postgres    false    215    218    218    218    218    215    215            T           0    0    TABLE my_view    ACL     d   GRANT SELECT ON TABLE public.my_view TO read_only;
GRANT ALL ON TABLE public.my_view TO all_rights;
          public          postgres    false    223            �            1259    16609    products    TABLE     �   CREATE TABLE public.products (
    id integer NOT NULL,
    nazvanie character varying(50) NOT NULL,
    price numeric(15,2) NOT NULL,
    quantity_stock integer NOT NULL
);
    DROP TABLE public.products;
       public         heap    postgres    false            U           0    0    TABLE products    ACL     f   GRANT SELECT ON TABLE public.products TO read_only;
GRANT ALL ON TABLE public.products TO all_rights;
          public          postgres    false    220            �            1259    16608    products_id_seq    SEQUENCE     �   CREATE SEQUENCE public.products_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.products_id_seq;
       public          postgres    false    220            V           0    0    products_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.products_id_seq OWNED BY public.products.id;
          public          postgres    false    219            W           0    0    SEQUENCE products_id_seq    ACL     <   GRANT ALL ON SEQUENCE public.products_id_seq TO all_rights;
          public          postgres    false    219            �           2604    16598    cheki id    DEFAULT     d   ALTER TABLE ONLY public.cheki ALTER COLUMN id SET DEFAULT nextval('public.cheki_id_seq'::regclass);
 7   ALTER TABLE public.cheki ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    216    218    218            �           2604    16599    cheki number_chek    DEFAULT     v   ALTER TABLE ONLY public.cheki ALTER COLUMN number_chek SET DEFAULT nextval('public.cheki_number_chek_seq'::regclass);
 @   ALTER TABLE public.cheki ALTER COLUMN number_chek DROP DEFAULT;
       public          postgres    false    218    217    218            �           2604    16590 
   kassiri id    DEFAULT     h   ALTER TABLE ONLY public.kassiri ALTER COLUMN id SET DEFAULT nextval('public.kassiri_id_seq'::regclass);
 9   ALTER TABLE public.kassiri ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    215    214    215            �           2604    16619    kuplen_products id    DEFAULT     x   ALTER TABLE ONLY public.kuplen_products ALTER COLUMN id SET DEFAULT nextval('public.kuplen_products_id_seq'::regclass);
 A   ALTER TABLE public.kuplen_products ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    221    222    222            �           2604    16612    products id    DEFAULT     j   ALTER TABLE ONLY public.products ALTER COLUMN id SET DEFAULT nextval('public.products_id_seq'::regclass);
 :   ALTER TABLE public.products ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    219    220    220            =          0    16595    cheki 
   TABLE DATA           E   COPY public.cheki (id, kas_id, number_chek, date_create) FROM stdin;
    public          postgres    false    218   ^q       :          0    16587    kassiri 
   TABLE DATA           <   COPY public.kassiri (id, fio_kassira, age, job) FROM stdin;
    public          postgres    false    215   �q       A          0    16616    kuplen_products 
   TABLE DATA           ]   COPY public.kuplen_products (id, check_id, product_id, quantity, price_products) FROM stdin;
    public          postgres    false    222   ,r       ?          0    16609    products 
   TABLE DATA           G   COPY public.products (id, nazvanie, price, quantity_stock) FROM stdin;
    public          postgres    false    220   br       X           0    0    cheki_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.cheki_id_seq', 3, true);
          public          postgres    false    216            Y           0    0    cheki_number_chek_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.cheki_number_chek_seq', 3, true);
          public          postgres    false    217            Z           0    0    kassiri_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.kassiri_id_seq', 4, true);
          public          postgres    false    214            [           0    0    kuplen_products_id_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.kuplen_products_id_seq', 2, true);
          public          postgres    false    221            \           0    0    products_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.products_id_seq', 5, true);
          public          postgres    false    219            �           2606    16602    cheki cheki_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.cheki
    ADD CONSTRAINT cheki_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.cheki DROP CONSTRAINT cheki_pkey;
       public            postgres    false    218            �           2606    16592    kassiri kassiri_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.kassiri
    ADD CONSTRAINT kassiri_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.kassiri DROP CONSTRAINT kassiri_pkey;
       public            postgres    false    215            �           2606    16621 $   kuplen_products kuplen_products_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public.kuplen_products
    ADD CONSTRAINT kuplen_products_pkey PRIMARY KEY (id);
 N   ALTER TABLE ONLY public.kuplen_products DROP CONSTRAINT kuplen_products_pkey;
       public            postgres    false    222            �           2606    16614    products products_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.products
    ADD CONSTRAINT products_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.products DROP CONSTRAINT products_pkey;
       public            postgres    false    220            �           1259    16653 	   indx_chek    INDEX     A   CREATE INDEX indx_chek ON public.cheki USING hash (number_chek);
    DROP INDEX public.indx_chek;
       public            postgres    false    218            �           1259    16652    indx_kas    INDEX     :   CREATE INDEX indx_kas ON public.kassiri USING btree (id);
    DROP INDEX public.indx_kas;
       public            postgres    false    215            �           2620    16672    my_view delete_view    TRIGGER     w   CREATE TRIGGER delete_view INSTEAD OF DELETE ON public.my_view FOR EACH ROW EXECUTE FUNCTION public.delete_row_view();
 ,   DROP TRIGGER delete_view ON public.my_view;
       public          postgres    false    256    223            �           2620    16669    my_view insert_view    TRIGGER     w   CREATE TRIGGER insert_view INSTEAD OF INSERT ON public.my_view FOR EACH ROW EXECUTE FUNCTION public.insert_row_view();
 ,   DROP TRIGGER insert_view ON public.my_view;
       public          postgres    false    223    254            �           2620    16645    kuplen_products trigger_add    TRIGGER     n   CREATE TRIGGER trigger_add AFTER INSERT ON public.kuplen_products FOR EACH ROW EXECUTE FUNCTION public.dob();
 4   DROP TRIGGER trigger_add ON public.kuplen_products;
       public          postgres    false    222    247            �           2620    16649    kuplen_products trigger_del    TRIGGER     n   CREATE TRIGGER trigger_del AFTER DELETE ON public.kuplen_products FOR EACH ROW EXECUTE FUNCTION public.del();
 4   DROP TRIGGER trigger_del ON public.kuplen_products;
       public          postgres    false    222    249            �           2620    16647    kuplen_products trigger_upd    TRIGGER     n   CREATE TRIGGER trigger_upd AFTER UPDATE ON public.kuplen_products FOR EACH ROW EXECUTE FUNCTION public.upd();
 4   DROP TRIGGER trigger_upd ON public.kuplen_products;
       public          postgres    false    248    222            �           2620    16675    my_view update_view    TRIGGER     w   CREATE TRIGGER update_view INSTEAD OF UPDATE ON public.my_view FOR EACH ROW EXECUTE FUNCTION public.update_row_view();
 ,   DROP TRIGGER update_view ON public.my_view;
       public          postgres    false    223    258            �           2606    16603    cheki cheki_kas_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.cheki
    ADD CONSTRAINT cheki_kas_id_fkey FOREIGN KEY (kas_id) REFERENCES public.kassiri(id) ON DELETE CASCADE;
 A   ALTER TABLE ONLY public.cheki DROP CONSTRAINT cheki_kas_id_fkey;
       public          postgres    false    3225    215    218            �           2606    16622 -   kuplen_products kuplen_products_check_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.kuplen_products
    ADD CONSTRAINT kuplen_products_check_id_fkey FOREIGN KEY (check_id) REFERENCES public.cheki(id) ON DELETE CASCADE;
 W   ALTER TABLE ONLY public.kuplen_products DROP CONSTRAINT kuplen_products_check_id_fkey;
       public          postgres    false    222    218    3227            �           2606    16627 /   kuplen_products kuplen_products_product_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.kuplen_products
    ADD CONSTRAINT kuplen_products_product_id_fkey FOREIGN KEY (product_id) REFERENCES public.products(id) ON DELETE CASCADE;
 Y   ALTER TABLE ONLY public.kuplen_products DROP CONSTRAINT kuplen_products_product_id_fkey;
       public          postgres    false    222    220    3230            =   =   x�3�4�4�4202�5��5�P04�22�20�2�C,2Ɯ ��T04�22�26����� J�      :   q   x�3估�¾{.l��Ho�41�0���/���e�ya���@�ŉ@iCKTi��6�u���_��o���b���
v!�6�0�b߅�v m���in�j`� d�W�      A   &   x�3�4BcNC3S=.#N# ǔ���̏���� ^      ?   u   x�M��1�*��d�|����>&%���@Pú#��d�i6�W�c�c�њ�#')?��w�1��LU����K�%���r�
ނn|�bBFrK�&=&�r��`IN*"_�;9�     